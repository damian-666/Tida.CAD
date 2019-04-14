﻿using System.Windows.Input;

namespace Tida.Canvas.Shell.Contracts.Ribbon {
    /// <summary>
    /// Ribbon按钮项的一个默认实现,便于动态创建Ribbon按钮项实例;
    /// </summary>
    public class RibbonButtonItem : IRibbonButtonItem {
        public ICommand Command { get; set; }

        public string GroupGUID { get; set; }

        public string GUID { get; set; }

        public string HeaderLanguageKey { get; set; }

        public string Icon { get; set; }

        public int Order { get; set; }
    }
}