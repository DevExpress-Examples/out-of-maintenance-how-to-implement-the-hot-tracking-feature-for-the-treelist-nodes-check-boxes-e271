using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.ViewInfo;

namespace DXSample
{
    public partial class MainForm : XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
            treeList.ExpandAll();
        }

        Rectangle hotTrackCheckBoxRectangle = Rectangle.Empty;

        public Rectangle HotTrackCheckBoxRectangle {
            get { return hotTrackCheckBoxRectangle; }
            set {
                if(hotTrackCheckBoxRectangle == value) return;
                Rectangle prevHotTrackCheckBoxRectangle = hotTrackCheckBoxRectangle;
                hotTrackCheckBoxRectangle = value;
                treeList.Invalidate(prevHotTrackCheckBoxRectangle);
                treeList.Invalidate(hotTrackCheckBoxRectangle);
            }
        }

        private void OnCustomDrawNodeCheckBox(object sender, DevExpress.XtraTreeList.CustomDrawNodeCheckBoxEventArgs e) {
            if(e.Bounds.Equals(HotTrackCheckBoxRectangle))
                e.ObjectArgs.State = DevExpress.Utils.Drawing.ObjectState.Hot;
        }

        private void OnMouseMove(object sender, MouseEventArgs e) {
            TreeList tree = sender as TreeList;
            TreeListHitInfo info = tree.CalcHitInfo(e.Location);
            if (info.HitInfoType == HitInfoType.NodeCheckBox)
                HotTrackCheckBoxRectangle = info.Bounds;
            else
                HotTrackCheckBoxRectangle = Rectangle.Empty;
           }
        }
}
    