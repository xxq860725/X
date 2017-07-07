﻿using System;

namespace XCode.Transform
{
    /// <summary>数据抽取参数</summary>
    public interface IExtractSetting
    {
        /// <summary>开始。大于等于</summary>
        DateTime Start { get; set; }

        /// <summary>结束。小于</summary>
        DateTime End { get; set; }

        /// <summary>开始行。分页</summary>
        Int32 Row { get; set; }

        /// <summary>步进。最大区间大小，秒</summary>
        Int32 Step { get; set; }

        /// <summary>批大小</summary>
        Int32 BatchSize { get; set; }

        /// <summary>启用</summary>
        Boolean Enable { get; set; }
    }

    /// <summary>数据抽取参数</summary>
    public class ExtractSetting : IExtractSetting
    {
        #region 属性
        /// <summary>开始。大于等于</summary>
        public DateTime Start { get; set; }

        /// <summary>结束。小于</summary>
        public DateTime End { get; set; }

        /// <summary>开始行。分页</summary>
        public Int32 Row { get; set; }

        /// <summary>步进。最大区间大小，秒</summary>
        public Int32 Step { get; set; }

        /// <summary>批大小</summary>
        public Int32 BatchSize { get; set; } = 5000;

        /// <summary>启用</summary>
        public Boolean Enable { get; set; } = true;
        #endregion

        #region 构造
        /// <summary>实例化</summary>
        public ExtractSetting() { }

        /// <summary>实例化</summary>
        /// <param name="set"></param>
        public ExtractSetting(IExtractSetting set)
        {
            Start = set.Start;
            End = set.End;
            Row = set.Row;
            Step = set.Step;
            BatchSize = set.BatchSize;
            Enable = set.Enable;
        }
        #endregion
    }
}