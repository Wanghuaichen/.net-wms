using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

using BenQGuru.eMES.Web.Helper ;
using BenQGuru.eMES.Web.UserControl ;
using BenQGuru.eMES.WebQuery ;
using BenQGuru.eMES.Common ;
using Infragistics.Web.UI.GridControls;
using Infragistics.Web.UI.LayoutControls;

namespace BenQGuru.eMES.Web.WebQuery
{
	/// <summary>
	/// FItemTracingQP ��ժҪ˵����
	/// </summary>
	public partial class FITOPResultSNQP : BaseMPageNew
	{
    

        private System.ComponentModel.IContainer components;
        private ControlLibrary.Web.Language.LanguageComponent languageComponent1;

        private QueryFacade2 _facade = null ; // FacadeFactory.CreateQueryFacade2() ;
        protected GridHelper gridSNHelper ;

        private string[] caredActions = new string[]
            {
                //ActionType.DataCollectAction_Split,
                //ActionType.DataCollectAction_IDTran
                ActionType.DataCollectAction_Convert
            } ;

        string rawURL = string.Empty ;


		#region Web ������������ɵĴ���
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: �õ����� ASP.NET Web ���������������ġ�
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
		/// </summary>
		private void InitializeComponent()
		{    
			this.components = new System.ComponentModel.Container();
			this.languageComponent1 = new ControlLibrary.Web.Language.LanguageComponent(this.components);
			//this.gridWebGrid.ClickCellButton += new Infragistics.WebUI.UltraWebGrid.ClickCellButtonEventHandler(this.gridWebGrid_ClickCellButton);
			// 
			// languageComponent1
			// 
			this.languageComponent1.Language = "CHS";
			this.languageComponent1.LanguagePackageDir = "D:\\SQC2.0\\eMES\\Source\\bin";
			this.languageComponent1.RuntimePage = null;
			this.languageComponent1.RuntimeUserControl = null;
			this.languageComponent1.UserControlName = "";

		}
		#endregion


        #region Init
        protected void Page_Load(object sender, System.EventArgs e)
        {
            try
            {
                string[] urls = this.Request.RawUrl.Split( new char[]{'/'} ) ;
                this.rawURL = urls[ urls.Length-1 ] ;
            }
            catch
            {
                this.rawURL = string.Empty  ;
            }

            if(!this.IsPostBack)
			{
                this.gridHelper = new GridHelperNew(this.gridWebGrid,this.DtSource);
                this.gridHelper2 = new GridHelperNew(this.gridWebGrid2,this.DtSource2);
				// ��ʼ��ҳ������
				this.InitPageLanguage(this.languageComponent1, false);

                string rcard = this.GetRequestParam("RCARD") ;
                int rcardseq ;
                try
                {
                    rcardseq = int.Parse( this.GetRequestParam("RCARDSEQ") );
                }
                catch
                {
                    rcardseq = -1 ;
                }
                string moCode = this.GetRequestParam("MOCODE") ;

				if(_facade==null)
				{
					_facade = new FacadeFactory(base.DataProvider).CreateQueryFacade2() ;
				}
                object obj = this._facade.GetProductionProcess( moCode,rcard,rcardseq ) ;
                if(obj == null)
                {
                    ExceptionManager.Raise(this.GetType() , "$Error_ItemTracing_not_exist") ;
                }

                this.txtItem.Value = ((ProductionProcess)obj).ItemCode ;
                this.txtMO.Value = ((ProductionProcess)obj).MOCode ; 
                this.txtModel.Value = ((ProductionProcess)obj).ModelCode ; 
                this.txtSN.Value = ((ProductionProcess)obj).RCard ; 
                this.txtSeq.Value = ((ProductionProcess)obj).RCardSequence.ToString() ;

            }

            //this.gridSNHelper = new GridHelper(this.gridSN) ;
            //this.gridSNHelper.LoadDataSourceHandle = new LoadDataSourceDelegate(this.LoadDataSourceSN);
            //this.gridSNHelper.GetRowCountHandle = new GetRowCountDelegate(this.GetRowCountSN);
            //this.gridSNHelper.BuildGridRowhandle = new BuildGridRowDelegate(this.GetGridRowSN);	

            //InitWebGridSN() ;
            //this.pagerSizeSelector.Readonly = true ;

        }

        protected override ControlLibrary.Web.Language.LanguageComponent GetLanguageComponent()
        {
            return this.languageComponent1;
        }
        #endregion

        #region WebGrid
        protected override void InitWebGrid()
        {
            base.InitWebGrid();
            this.gridHelper.AddColumn("IT_Route","����;��",null) ;
            this.gridHelper.AddColumn( "IT_OP", "����",	null);
            this.gridHelper.AddColumn( "IT_ItemStatus", "��Ʒ״̬",	null);
            this.gridHelper.AddColumn( "IT_OPType", "������",	null);
            this.gridHelper.AddLinkColumn( "IT_OPResult", "������",	null);
            this.gridHelper.AddColumn( "IT_Segment", "����",	null);
            this.gridHelper.AddColumn( "IT_Line", "������",	null);
            this.gridHelper.AddColumn( "IT_Resource", "��Դ",	null);
            this.gridHelper.AddColumn( "IT_MaintainDate", "����",	null);
            this.gridHelper.AddColumn( "IT_MaintainTime", "ʱ��",	null);
            this.gridHelper.AddColumn( "IT_MaintainUser", "������",	null);

            this.gridHelper.AddColumn( "IT_OPType_ORI", "������",	null);

            this.gridHelper.Grid.Columns.FromKey("IT_OPType_ORI").Hidden = true ;
			this.gridHelper.Grid.Columns.FromKey("IT_OPResult").Hidden = true ;

			//������
			this.gridHelper.ApplyLanguage( this.languageComponent1 );
 
           // base.InitWebGrid();

            this.gridHelper.RequestData();

        }
		
        protected override DataRow GetGridRow(object obj)
        {
            //return new Infragistics.WebUI.UltraWebGrid.UltraGridRow( 
            //    new object[]{
            //                    ((OPResult)obj).RouteCode.ToString(),
            //                    ((OPResult)obj).OPCode.ToString(),
            //                    this.languageComponent1.GetString( ((OPResult)obj).ItemStatus ),
            //                    //WebQueryHelper.GetOPResultLinkText(this.languageComponent1,((OPResult)obj).OPType),
            //                    this.languageComponent1.GetString("ItemTracing_sn"),
            //                    "",
            //                    ((OPResult)obj).SegmentCode.ToString(),
            //                    ((OPResult)obj).LineCode.ToString(),
            //                    ((OPResult)obj).ResCode.ToString(),
            //                    FormatHelper.ToDateString(((OPResult)obj).MaintainDate),
            //                    FormatHelper.ToTimeString(((OPResult)obj).MaintainTime),
            //                    ((OPResult)obj).MaintainUser.ToString(),
            //                    ((OPResult)obj).OPType.ToString()
            //                }
            //    );

            DataRow row = this.DtSource.NewRow();
            row["IT_Route"] = ((OPResult)obj).RouteCode.ToString();
            row["IT_OP"] = ((OPResult)obj).OPCode.ToString();
            row["IT_ItemStatus"] = this.languageComponent1.GetString(((OPResult)obj).ItemStatus);
            row["IT_OPType"] = this.languageComponent1.GetString("ItemTracing_sn");
            row["IT_Segment"] = ((OPResult)obj).SegmentCode.ToString();
            row["IT_Line"] = ((OPResult)obj).LineCode.ToString();
            row["IT_Resource"] = ((OPResult)obj).ResCode.ToString();
            row["IT_MaintainDate"] = FormatHelper.ToDateString(((OPResult)obj).MaintainDate);
            row["IT_MaintainTime"] = FormatHelper.ToTimeString(((OPResult)obj).MaintainTime);
            row["IT_MaintainUser"] = ((OPResult)obj).MaintainUser.ToString();
            row["IT_OPType_ORI"] = ((OPResult)obj).OPType.ToString();
            return row;
        }

        protected override object[] LoadDataSource(int inclusive, int exclusive)
        {
            int seq ;
            try
            {
                seq = int.Parse(this.txtSeq.Value) ;
            }
            catch
            {
                seq = -1 ;
            }

			if(_facade==null)
			{
				_facade = new FacadeFactory(base.DataProvider).CreateQueryFacade2() ;
			}
            return this._facade.QueryOPResult(
                this.txtMO.Value,
                this.txtSN.Value ,
                seq,
                caredActions,
                inclusive, exclusive );
        }


        protected override int GetRowCount()
        {
            int seq ;
            try
            {
                seq = int.Parse(this.txtSeq.Value) ;
            }
            catch
            {
                seq = -1 ;
            }

			if(_facade==null)
			{
				_facade = new FacadeFactory(base.DataProvider).CreateQueryFacade2() ;
			}
            return this._facade.QueryOPResultCount(
                this.txtMO.Value,
                this.txtSN.Value,
                seq,
                caredActions
                );
        }

        #endregion
        

        #region SNGrid
        protected override void InitWebGrid2()
        {
            base.InitWebGrid2();
            this.gridHelper2.AddColumn("IT_SN_old","ԭ���к�",null) ;
            this.gridHelper2.AddColumn("IT_SN_new", "�����к�", null);

            ((BoundDataField)this.gridHelper2.Grid.Columns.FromKey("IT_SN_old")).HtmlEncode = false;
            ((BoundDataField)this.gridHelper2.Grid.Columns.FromKey("IT_SN_new")).HtmlEncode = false; 
            // ���úϲ���Ԫ�����ʽ
            //this.gridHelper2.Grid.Columns.FromKey("IT_SN_old").MergeCells = true;
            //this.gridHelper2.Grid.Columns.FromKey("IT_SN_old").CellStyle.CustomRules = "text-align:left;vertical-align:top;";

            this.gridHelper2.ApplyLanguage(this.languageComponent1);

            this.gridHelper2.RequestData();

        }

        protected override DataRow GetGridRow2(object obj)
        {
            //return new Infragistics.WebUI.UltraWebGrid.UltraGridRow( 
            //    new object[]{
            //                    WebQueryHelper.GetProductionProcessHtml(
            //                        ((SNInfo)obj).TranslateCard,
            //                        -1,
            //                        string.Empty,
            //                        this.rawURL,
            //                        true),
            //                    WebQueryHelper.GetProductionProcessHtml(
            //                        ((SNInfo)obj).RunningCard,
            //                        -1,
            //                        string.Empty,
            //                        this.rawURL,
            //                        true)
            //    );
            DataRow row=this.DtSource2.NewRow();
            row["IT_SN_old"] = WebQueryHelper.GetProductionProcessHtml(
                                    ((SNInfo)obj).TranslateCard,
                                    -1,
                                    string.Empty,
                                    this.rawURL,
                                    true);
            row["IT_SN_new"] = WebQueryHelper.GetProductionProcessHtml(
                                    ((SNInfo)obj).RunningCard,
                                    -1,
                                    string.Empty,
                                    this.rawURL,
                                    true);
            return row;
        }

        protected override object[] LoadDataSource2(int inclusive, int exclusive)
        {
			if(_facade==null)
			{
				_facade = new FacadeFactory(base.DataProvider).CreateQueryFacade2() ;
			}
            return this._facade.QuerySNInfoNew(
                this.txtMO.Value,
                this.txtSN.Value ,
                int.Parse( this.txtSeq.Value) ,
                1, int.MaxValue );
        }

        protected override int GetRowCount2()
        {
			if(_facade==null)
			{
				_facade = new FacadeFactory(base.DataProvider).CreateQueryFacade2() ;
			}
            return this._facade.QuerySNInfoCountNew(
                this.txtMO.Value,
                this.txtSN.Value
                );
        }

        #endregion


        #region Export 	
        protected override string[] FormatExportRecord( object obj )
        {
            return  new string[]{
                                    ((OPResult)obj).RouteCode.ToString(),
                                    ((OPResult)obj).OPCode.ToString(),
                                    this.languageComponent1.GetString( ((OPResult)obj).ItemStatus ),
									//WebQueryHelper.GetOPResultLinkText(this.languageComponent1,((OPResult)obj).OPType),
									this.languageComponent1.GetString("ItemTracing_sn"),
                                    ((OPResult)obj).SegmentCode.ToString(),
                                    ((OPResult)obj).LineCode.ToString(),
                                    ((OPResult)obj).ResCode.ToString(),
                                    FormatHelper.ToDateString(((OPResult)obj).MaintainDate),
                                    FormatHelper.ToTimeString(((OPResult)obj).MaintainTime),
                                    ((OPResult)obj).MaintainUser.ToString(),
            }
            ;
        }

        protected override string[] GetColumnHeaderText()
        {
            return new string[] {
                                    "IT_Route", 
                                    "IT_OP", 
                                    "IT_ItemStatus", 
                                    "IT_OPType", 
                                    "IT_Segment", 
                                    "IT_Line", 
                                    "IT_Resource", 
                                    "IT_MaintainDate", 
                                    "IT_MaintainTime", 
                                    "IT_MaintainUser"
                                };
        }
        #endregion

        protected override void Grid_ClickCell(GridRecord row, string command)
        {

            string opType = row.Items.FindItemByKey("IT_OPType_ORI").Text;

            if(command=="IT_OPResult")
            {
                string gotoURL = string.Empty ;

                if(opType == BenQGuru.eMES.Web.Helper.OPType.COMPLOADING)
                {
                    gotoURL = "FITOPResultComploadingQP.aspx" ;
                }

                if(opType == BenQGuru.eMES.Web.Helper.OPType.PACKING)
                {
                    gotoURL = "FITOPResultPackingQP.aspx" ;
                }

                if(opType == BenQGuru.eMES.Web.Helper.OPType.SN)
                {
                    gotoURL = "FITOPResultSNQP.aspx" ;
                }

                if(opType == BenQGuru.eMES.Web.Helper.OPType.TESTING)
                {
                    gotoURL = "FITOPResultTestingQP.aspx" ;
                }

                if(opType == BenQGuru.eMES.Web.Helper.OPType.TS)
                {
                    gotoURL = "FITOPResultTSQP.aspx" ;
                }

                Response.Redirect(string.Format("{0}?RCARD={1}", gotoURL, row.Items.FindItemByKey("IT_OP").Text));
            }

        }

        protected void cmdReturn_ServerClick(object sender, System.EventArgs e)
        {
            string referedURL = this.GetRequestParam("REFEREDURL") ;
            if( referedURL == string.Empty)
            {
                referedURL = "FItemTracingQP.aspx" ;
            }
            else
            {
                referedURL = System.Web.HttpUtility.UrlDecode(referedURL) ;
            }
            Response.Redirect( referedURL ) ;
        }


	}
}