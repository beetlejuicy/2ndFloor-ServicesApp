﻿using System.Collections.Generic;
using System.Text;
using SecondFloor.I18n;

namespace SecondFloor.Infrastructure.Model
{
    public class EntityBase<TId> : IEntityBase<TId>
    {
        public TId Id { get; set; }

        private IDictionary<string,string> _brokenRules = new Dictionary<string, string>();
        //private IList<BusinessRule> _brokenRules= new List<BusinessRule>();

        public IDictionary<string,string> BrokenRules
        {
            get { return _brokenRules; }
        }

        //protected abstract void Validate();

        /*public virtual IList<BusinessRule> GetBrokenRules()
        {
            return brokenRules;
        }*/

        public void AddBrokenRule(string key, string message)
        {
            if ( this._brokenRules.ContainsKey(key) )
                _brokenRules[key] = message;
            else
                _brokenRules.Add(key, message);
        }

        public void AddRangeBrokenRules(IDictionary<string,string> businessRules)
        {
            foreach (var businessRule in businessRules)
            {
                this._brokenRules.Add(businessRule);
            }
        }

        public StringBuilder GetErrorMessages()
        {
            var sb = new StringBuilder();
            sb.Append(Resources.Infrastructure_Model_EntityBase_GetErrorMessages);
            foreach (var error in this._brokenRules)
            {
                sb.Append("<br/>");
                sb.AppendLine(error.Value);
            }
            return sb;
        }

        public void ClearBrokenRules()
        {
            this._brokenRules.Clear();
        }
    }
}