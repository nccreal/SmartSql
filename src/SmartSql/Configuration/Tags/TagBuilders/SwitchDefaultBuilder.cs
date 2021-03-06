using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace SmartSql.Configuration.Tags.TagBuilders
{
    public class SwitchDefaultBuilder : AbstractTagBuilder
    {
        public override ITag Build(XmlNode xmlNode, Statement statement)
        {
            var switchNode = xmlNode.ParentNode;
            return new Switch.Default
            {
                Property = GetProperty(switchNode),
                Prepend = GetPrepend(switchNode),
                ChildTags = new List<ITag>(),
                Statement = statement
            };
        }
    }
}
