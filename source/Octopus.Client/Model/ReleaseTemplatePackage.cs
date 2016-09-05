﻿using System;

namespace Octopus.Client.Model
{
    public class ReleaseTemplatePackage
    {
        public string StepName { get; set; }

        // TODO: [ObsoleteEx(TreatAsErrorFromVersion = "4.0", RemoveInVersion = "4.0", ReplacementTypeOrMember = "PackageId")]
        public string NuGetPackageId
        {
            get { return PackageId; }
            set { PackageId = value; }
        }

        public string PackageId { get; set; }

        // TODO: [ObsoleteEx(TreatAsErrorFromVersion = "4.0", RemoveInVersion = "4.0", ReplacementTypeOrMember = "FeedId")]
        public string NuGetFeedId
        {
            get { return FeedId; }
            set { FeedId = value; }
        }

        public string FeedId { get; set; }

        // TODO: [ObsoleteEx(TreatAsErrorFromVersion = "4.0", RemoveInVersion = "4.0", ReplacementTypeOrMember = "FeedName")]
        public string NuGetFeedName
        {
            get { return FeedName; }
            set { FeedName = value; }
        }

        public string FeedName { get; set; }

        public string VersionSelectedLastRelease { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the <see cref="PackageId" /> or <see cref="FeedId" /> contain no
        /// references to other variables. Variables can be used to
        /// select different NuGet feeds or packages at deployment time, however, this means that it's not possible to resolve
        /// which feed/package to search when creating a release.
        /// </summary>
        public bool IsResolvable { get; set; }
    }
}