﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TFSWorkItemQueryService.Repository
{
    public class ProjectMacro
        : IMacro
    {
        private ITfsContext tfsContext;

        public ProjectMacro(ITfsContext tfsContext)
        {
            this.tfsContext = tfsContext;
        }
        
        public string GetValue()
        {
            return tfsContext.CurrentProject;
        }

        public string Name
        {
            get
            {
                return "Project";
            }
        }
    }
}