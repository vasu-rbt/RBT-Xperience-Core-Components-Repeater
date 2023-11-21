namespace Repeater.Models
{
    public class RepeaterDto
    {
        /// <summary>
        /// Current page type name
        /// </summary>
        public string? PageTypeClassName { get; set; }
        /// <summary>
        /// Selected page path
        /// </summary>
        public string? SelectedPath { get; set; }
        /// <summary>
        /// Number of records display
        /// </summary>
        public int TopN { get; set; }
        /// <summary>
        /// Order by filter data
        /// </summary>
        public string? OrderBy { get; set; }
        public string? Where { get; set; }
    }
}
