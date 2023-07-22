namespace HtmlValues.AttributeValues;

/// /// <summary>
/// Provides access to predefined values for the <c>role</c> attribute.
/// </summary>
public class RoleValues
{
    /// <summary>
    /// Gets the predefined <c>alert</c> attribute value. This role is for important, and usually time-sensitive, information.
    /// </summary>
    public string Alert => HtmlAttributeValues.Alert;

    /// <summary>
    /// Gets the predefined <c>alertdialog</c> attribute value. This role is to be used on modal alert dialogs that interrupt a user's workflow to communicate an important message and require a response.
    /// </summary>
    public string AlertDialog => HtmlAttributeValues.AlertDialog;

    /// <summary>
    /// Gets the predefined <c>application</c> attribute value. This role indicates to assistive technologies that an element and all of its children should be treated similar to a desktop application and not traditional HTML interpretation techniques should be used.
    /// This role should only be used to define very dynamic and desktop-like web applications. Mode mobile and desktop web apps are not considered applications for this purpose.
    /// </summary>
    public string Application => HtmlAttributeValues.Application;

    /// <summary>
    /// Gets the predefined <c>article</c> attribute value. This role indicates a section of a page that could easily stand on its own on a page, in a document, or on a website.
    /// It is usually set on related content items such as comments, forum posts, or newspaper articles or other items grouped together on one page.
    /// </summary>
    public string Article => HtmlAttributeValues.Article;

    /// <summary>
    /// Gets the predefined <c>addociationlist</c> attribute value. This role contains only <c>associationlistitemkey</c> children and their sibling <c>associationlistitemvalue</c> elements.
    /// </summary>
    public string AssociationList => HtmlAttributeValues.AssociationList;

    /// <summary>
    /// Gets the predefined <c>addociationlistitemkey</c> attribute value. This role is used to identify the key of a key/value pair in an <c>associationlist</c>.
    /// </summary>
    public string AssociationListItemKey => HtmlAttributeValues.AssociationListItemKey;

    /// <summary>
    /// Gets the predefined <c>addociationlistitemvalue</c> attribute value. This role is used to identify the value of a key/value pair in an <c>associationlist</c>.
    /// </summary>
    public string AssociationListItemValue => HtmlAttributeValues.AssociationListItemValue;

    /// <summary>
    /// Gets the predefined <c>banner</c> attribute value. This role is for defining a global site header, which usually includes a logo, company name, search feature, and possibly the global navigation or a slogan.
    /// It is generally located at the top of the page.
    /// </summary>
    public string Banner => HtmlAttributeValues.Banner;

    /// <summary>
    /// Gets the predefined <c>blockquote</c> attribute value. This role is used to identify a section of quoted text from another source.
    /// </summary>
    public string BlockQuote => HtmlAttributeValues.BlockQuote;

    /// <summary>
    /// Gets the predefined <c>button</c> attribute value. This role is for clickable elements that trigger a response when activated by the user.
    /// </summary>
    public string Button => HtmlAttributeValues.Button;

    /// <summary>
    /// Gets the predefined <c>caption</c> attribute value. This role identifies content that names and may also describe a <c>figure</c>, <c>table</c>, <c>grid</c>, or <c>treegrid</c>.
    /// </summary>
    public string Caption => HtmlAttributeValues.Caption;

    /// <summary>
    /// Gets the predefined <c>cell</c> attribute value. This role identifies an element as being a cell in a tablular container that does not contain column or row header information.
    /// To be supported, the cell must be nested in an element with the role of <c>row</c>.
    /// </summary>
    public string Cell => HtmlAttributeValues.Cell;

    /// <summary>
    /// Gets the predefined <c>checkbox</c> attribute value. This role is for checkable interactive controls. Elements with this role should also include the <c>aria-checked</c> attribute to expose the checkbox's state to assistive technologies.
    /// </summary>
    public string Checkbox => HtmlAttributeValues.Checkbox;

    /// <summary>
    /// Gets the predefined <c>code</c> attribute value. This role is used to identify content that represents a fragment of computer code.
    /// </summary>
    public string Code => HtmlAttributeValues.Code;

    /// <summary>
    /// Gets the predefined <c>columnheader</c> attribute value. This role identifies an element as being a cell in a row that contains header information for a column.
    /// </summary>
    public string ColumnHeader => HtmlAttributeValues.ColumnHeader;

    /// <summary>
    /// Gets the predefined <c>combobox</c> attribute value. This role identifies an element as an <c>input</c> that controls another element, such as a <c>listbox</c> or <c>grid</c>, that can dynamically pop up to help the user set the value of the <c>intput</c>.
    /// </summary>
    public string ComboBox => HtmlAttributeValues.ComboBox;

    /// <summary>
    /// Gets the predefined <c>comment</c> attribute value. This landmark role semantically denotes a comment/reaction to some content on the page, or a previous comment.
    /// </summary>
    public string Comment => HtmlAttributeValues.Comment;

    /// <summary>
    /// Gets the predefined <c>complementary</c> attribute value. This landmark role is used to designate a supporting section that relates to the main content, yet can stand alone when separated.
    /// These sections are frequently presented as sidebars or call-out boxes. If possible, use the <c>aside</c> element instead.
    /// </summary>
    public string Complementary => HtmlAttributeValues.Complementary;

    /// <summary>
    /// Gets the predefined <c>contentinfo</c> attribute value. This role defines a footer, containing identifying information such as copyright information, navigation links, and privacy statements, found on every document withing a site.
    /// This section is commonly called a footer.
    /// </summary>
    public string ContentInfo => HtmlAttributeValues.ContentInfo;

    /// <summary>
    /// Gets the predefined <c>definition</c> attribute value. This role is used to identify the definition of a term or concept.
    /// </summary>
    public string Definition => HtmlAttributeValues.Definition;

    /// <summary>
    /// Gets the predefined <c>deletion</c> attribute value. This role is used to identify content that is marked as removed or suggested for removal.
    /// </summary>
    public string Deletion => HtmlAttributeValues.Deletion;

    /// <summary>
    /// Gets the predefined <c>dialog</c> attribute value. This role is used to mark up an HTML based application dialog or window that separates content or UI from the rest of the web application or page.
    /// </summary>
    public string Dialog => HtmlAttributeValues.Dialog;

    /// <summary>
    /// Gets the predefined <c>document</c> attribute value. This role is for focusable content within complex composite widgets or applications for which assistive technologies can switch the reading context back to a reading mode.
    /// </summary>
    public string Document => HtmlAttributeValues.Document;

    /// <summary>
    /// Gets the predefined <c>emphasis</c> attribute value. This role is used to stress or emphasize content, but not to suggest importance.
    /// </summary>
    public string Emphasis => HtmlAttributeValues.Emphasis;

    /// <summary>
    /// Gets the predefined <c>feed</c> attribute value. This role is a dynamic scrollable <c>list</c> of <c>articles</c> in which articles are added to or removed
    /// from either in of this list as the user scrolls.
    /// </summary>
    public string Feed => HtmlAttributeValues.Feed;

    /// <summary>
    /// Gets the predefined <c>figure</c> attribute value. This role is used as a container for a graphical document, images, code snippets, or example text.
    /// </summary>
    public string Figure => HtmlAttributeValues.Figure;

    /// <summary>
    /// Gets the predefined <c>form</c> attribute value. This role is used to identify a group of elements on a page that provide equivalent functionality to an HTML form.
    /// </summary>
    public string Form => HtmlAttributeValues.Form;

    /// <summary>
    /// Gets the predefined <c>generic</c> attribute value. This role creates a nameless container element which has no semantic meaning on its own.
    /// </summary>
    public string Generic => HtmlAttributeValues.Generic;

    /// <summary>
    /// Gets the predefined <c>grid</c> attribute value. This role is for a widget that contains a collection of one or more rows with one or more cells.
    /// </summary>
    public string Grid => HtmlAttributeValues.Grid;

    /// <summary>
    /// Gets the predefined <c>gridcell</c> attribute value. This role is used to make a cell in a <c>grid</c> or <c>treegrid</c>.
    /// </summary>
    public string GridCell => HtmlAttributeValues.GridCell;

    /// <summary>
    /// Gets the predefined <c>group</c> attribute value. This role is used to identify a set of user interface objects which are
    /// not intended to be included in a page summary or table of contents by assistive technologies.
    /// </summary>
    public string Group => HtmlAttributeValues.Group;

    /// <summary>
    /// Gets the predefined <c>heading</c> attribute value. This role is used to identify the headings for a section of the page.
    /// </summary>
    public string Heading => HtmlAttributeValues.Heading;

    /// <summary>
    /// Gets the predefined <c>image</c> attribute value. This role is used to identify an image element. Synonymous with <c>img</c>.
    /// </summary>
    public string Image => HtmlAttributeValues.Image;

    /// <summary>
    /// Gets the predefined <c>img</c> attribute value. This role is used to identify an image element. Synonymous with <c>image</c>.
    /// </summary>
    public string Img => HtmlAttributeValues.Img;

    /// <summary>
    /// Gets the predefined <c>insertion</c> attribute value. This role is used to identify content that is marked as added or suggested as an addition.
    /// </summary>
    public string Insertion => HtmlAttributeValues.Insertion;

    /// <summary>
    /// Gets the predefined <c>link</c> attribute value. This role is used for a widget which provides an
    /// interactive reference to resource.
    /// </summary>
    public string Link => HtmlAttributeValues.Link;

    /// <summary>
    /// Gets the predefined <c>list</c> attribute value. This role is used to identify a section containing a collection <c>listitem</c> elements.
    /// </summary>
    public string List => HtmlAttributeValues.List;

    /// <summary>
    /// Gets the predefined <c>listbox</c> attribute value. This role is used to identify an element that allows the
    /// user to select one or more items from a list of choices.
    /// </summary>
    public string ListBox => HtmlAttributeValues.ListBox;

    /// <summary>
    /// Gets the predefined <c>listitem</c> attribute value. This role is used to identify the items in a <c>list</c>.
    /// </summary>
    public string ListItem => HtmlAttributeValues.ListItem;

    /// <summary>
    /// Gets the predefined <c>log</c> attribute value. This role is used to identify a type of live region where new
    /// information is added in meaningful order and old information may disappear.
    /// </summary>
    public string Log => HtmlAttributeValues.Log;

    /// <summary>
    /// Gets the predefined <c>main</c> attribute value. This role is used to identify the primary content of a document.
    /// </summary>
    public string Main => HtmlAttributeValues.Main;

    /// <summary>
    /// Gets the predefined <c>mark</c> attribute value. This role is used to identify text that is highlighted or marked in some way, often with a yellow background.
    /// </summary>
    public string Mark => HtmlAttributeValues.Mark;

    /// <summary>
    /// Gets the predefined <c>marquee</c> attribute value. This role is used to identify an element that contains non-essential
    /// information which changes frequently.
    /// </summary>
    public string Marquee => HtmlAttributeValues.Marquee;

    /// <summary>
    /// Gets the predefined <c>math</c> attribute value. This role is used to identify content which represents a mathematical expression.
    /// </summary>
    public string Math => HtmlAttributeValues.Math;

    /// <summary>
    /// Gets the predefined <c>menu</c> attribute value. This role is used to identify a type of widget that offers a list of choices to the user.
    /// </summary>
    public string Menu => HtmlAttributeValues.Menu;

    /// <summary>
    /// Gets the predefined <c>menubar</c> attribute value. This role is used to identify a presentation of menu that usually
    /// remains visible and is usually presented horizontally.
    /// </summary>
    public string MenuBar => HtmlAttributeValues.MenuBar;

    /// <summary>
    /// Gets the predefined <c>menuitem</c> attribute value. This role is used to identify an actionable item in a <c>menu</c>.
    /// </summary>
    public string MenuItem => HtmlAttributeValues.MenuItem;

    /// <summary>
    /// Gets the predefined <c>menuitemcheckbox</c> attribute value. This role is used to identify a selectable item in a <c>menu</c>.
    /// </summary>
    public string MenuItemCheckbox => HtmlAttributeValues.MenuItemCheckbox;

    /// <summary>
    /// Gets the predefined <c>menuitemradio</c> attribute value. This role is used to identify a selectable item in a <c>menu</c>
    /// where only one item can be selected in a group.
    /// </summary>
    public string MenuItemRadio => HtmlAttributeValues.MenuItemRadio;

    /// <summary>
    /// Gets the predefined <c>meter</c> attribute value. This role is used to identify a scalar measurement within a known range, or a fractional value.
    /// </summary>
    public string Meter => HtmlAttributeValues.Meter;

    /// <summary>
    /// Gets the predefined <c>navigation</c> attribute value. This role is used to identify a collection of navigational
    /// elements (usually links) for navigating the document or related documents.
    /// </summary>
    public string Navigation => HtmlAttributeValues.Navigation;

    /// <summary>
    /// Gets the predefined <c>none</c> attribute value. This role is used to identify content which
    /// is not to be exposed to the accessibility tree.
    /// </summary>
    public string None => HtmlAttributeValues.None;

    /// <summary>
    /// Gets the predefined <c>note</c> attribute value. This role is used to identify a section whose content
    /// is parenthetic or ancillary to the main content of the resource.
    /// </summary>
    public string Note => HtmlAttributeValues.Note;

    /// <summary>
    /// Gets the predefined <c>option</c> attribute value. This role is used to identify selectable items in a <c>listbox</c>.
    /// </summary>
    public string Option => HtmlAttributeValues.Option;

    /// <summary>
    /// Gets the predefined <c>paragraph</c> attribute value. This role is used to identify a paragraph of content.
    /// </summary>
    public string Paragraph => HtmlAttributeValues.Paragraph;

    /// <summary>
    /// Gets the predefined <c>presentation</c> attribute value. This role is a synonym for <c>none</c> and is used to
    /// identify content which is not to be exposed to the accessibility tree.
    /// </summary>
    public string Presentation => HtmlAttributeValues.Presentation;

    /// <summary>
    /// Gets the predefined <c>progressbar</c> attribute value. This role is used to identify an element that displays the
    /// progress status for tasks that take a long time.
    /// </summary>
    public string ProgressBar => HtmlAttributeValues.ProgressBar;

    /// <summary>
    /// Gets the predefined <c>radio</c> attribute value. This role is used to identify a selectable input in a group
    /// where only one can be selected.
    /// </summary>
    public string Radio => HtmlAttributeValues.Radio;

    /// <summary>
    /// Gets the predefined <c>radiogroup</c> attribute value. This role is used to identify a group of <c>radio</c> buttons.
    /// </summary>
    public string RadioGroup => HtmlAttributeValues.RadioGroup;

    /// <summary>
    /// Gets the predefined <c>region</c> attribute value. This role is used to identify document areas which
    /// the author deems significant.
    /// </summary>
    public string Region => HtmlAttributeValues.Region;

    /// <summary>
    /// Gets the predefined <c>row</c> attribute value. This role is used to identify a row of cells within a
    /// tabular structure.
    /// </summary>
    public string Row => HtmlAttributeValues.Row;

    /// <summary>
    /// Gets the predefined <c>rowgroup</c> attribute value. This role is used to identify a group of rows within a
    /// tabular structure.
    /// </summary>
    public string RowGroup => HtmlAttributeValues.RowGroup;

    /// <summary>
    /// Gets the predefined <c>rowheader</c> attribute value. This role is used to identify a cell containing header information
    /// for a <c>row</c> in a tabular structure.
    /// </summary>
    public string RowHeader => HtmlAttributeValues.RowHeader;

    /// <summary>
    /// Gets the predefined <c>scrollbar</c> attribute value. This role is used to identify a graphical object that controls the scrolling
    /// within a viewing area.
    /// </summary>
    public string Scrollbar => HtmlAttributeValues.Scrollbar;

    /// <summary>
    /// Gets the predefined <c>search</c> attribute value. This role is used to identify a section of the page, site, or collection of sites.
    /// </summary>
    public string Search => HtmlAttributeValues.Search;

    /// <summary>
    /// Gets the predefined <c>searchbox</c> attribute value. This role is used to identify an element that allows the user to input search criteria.
    /// </summary>
    public string SearchBox => HtmlAttributeValues.SearchBox;

    /// <summary>
    /// Gets the predefined <c>separator</c> attribute value. This role is used to identify an element that separates
    /// and distinguishes sections of content or groups of menuitems.
    /// </summary>
    public string Separator => HtmlAttributeValues.Separator;

    /// <summary>
    /// Gets the predefined <c>slider</c> attribute value. This role is used to identify an
    /// element that allows the user to select from a range of values.
    /// </summary>
    public string Slider => HtmlAttributeValues.Slider;

    /// <summary>
    /// Gets the predefined <c>spinbutton</c> attribute value. This role is used to identify an element
    /// that allows the user to incrementally increase or decrease a value.
    /// </summary>
    public string SpinButton => HtmlAttributeValues.SpinButton;

    /// <summary>
    /// Gets the predefined <c>status</c> attribute value. This role is used to identify a region containing
    /// advisory information that is not important enough to justify an alert.
    /// </summary>
    public string Status => HtmlAttributeValues.Status;

    /// <summary>
    /// Gets the predefined <c>strong</c> attribute value. This role is used to identify content that has strong importance, seriousness, or urgency.
    /// </summary>
    public string Strong => HtmlAttributeValues.Strong;

    /// <summary>
    /// Gets the predefined <c>subscript</c> attribute value. This role is used to identify subscript text.
    /// </summary>
    public string Subscript => HtmlAttributeValues.Subscript;

    /// <summary>
    /// Gets the predefined <c>suggestion</c> attribute value. This role is used to semantically denote a single proposed change
    /// to an editable document. This should be used on an element that wraps an element with an <c>insertion</c> roll or <c>deletion</c> role.
    /// </summary>
    public string Suggestion => HtmlAttributeValues.Suggestion;

    /// <summary>
    /// Gets the predefined <c>superscript</c> attribute value. This role is used to identify superscript text.
    /// </summary>
    public string Superscript => HtmlAttributeValues.Superscript;

    /// <summary>
    /// Gets the predefined <c>switch</c> attribute value. This role is used to identify a type of checkbox that represents on/off values,
    /// </summary>
    public string Switch => HtmlAttributeValues.Switch;

    /// <summary>
    /// Gets the predefined <c>tab</c> attribute value. This role is used to identify a grouping label providing a mechanism for selecting the tab content.
    /// </summary>
    public string Tab => HtmlAttributeValues.Tab;

    /// <summary>
    /// Gets the predefined <c>table</c> attribute value. This role is used to identify a non-interactive section containing data arranged in rows and columns.
    /// </summary>
    public string Table => HtmlAttributeValues.Table;

    /// <summary>
    /// Gets the predefined <c>tablist</c> attribute value. This role is used to identify a container for a set of <c>tab</c> elements.
    /// </summary>
    public string TabList => HtmlAttributeValues.TabList;

    /// <summary>
    /// Gets the predefined <c>tabpanel</c> attribute value. This role is used to identify a container for the resources associated with a <c>tab</c>.
    /// </summary>
    public string TabPanel => HtmlAttributeValues.TabPanel;

    /// <summary>
    /// Gets the predefined <c>term</c> attribute value. This role is used to identify a word or phrase with an optional corresponding definition.
    /// </summary>
    public string Term => HtmlAttributeValues.Term;

    /// <summary>
    /// Gets the predefined <c>textbox</c> attribute value. This role is used to identify an element that allows the user to input free-form text.
    /// </summary>
    public string TextBox => HtmlAttributeValues.TextBox;

    /// <summary>
    /// Gets the predefined <c>time</c> attribute value. This role is used to identify a specific point in time.
    /// </summary>
    public string Time => HtmlAttributeValues.Time;

    /// <summary>
    /// Gets the predefined <c>timer</c> attribute value. This role is used to identify an element that displays a numerical counter
    /// listing the amount of elapsed time from a start point, or the time remaining until an end point.
    /// </summary>
    public string Timer => HtmlAttributeValues.Timer;

    /// <summary>
    /// Gets the predefined <c>toolbar</c> attribute value. This role is used to identify a collection of commonly used function buttons
    /// or controls represented in compact visual form.
    /// </summary>
    public string Toolbar => HtmlAttributeValues.Toolbar;

    /// <summary>
    /// Gets the predefined <c>tooltip</c> attribute value. This role is used to identify a contextual popup that displays a description
    /// for an element that appears on pointer hover or keyboard focus.
    /// </summary>
    public string Tooltip => HtmlAttributeValues.Tooltip;

    /// <summary>
    /// Gets the predefined <c>tree</c> attribute value. This role is used to identify a widget that allows the user to select one or more items
    /// from a hierarchically organized collection.
    /// </summary>
    public string Tree => HtmlAttributeValues.Tree;

    /// <summary>
    /// Gets the predefined <c>treegrid</c> attribute value. This role is used to identify a grid whose rows can be expanded and collapsed in the same manner
    /// as a <c>tree</c>.
    /// </summary>
    public string TreeGrid => HtmlAttributeValues.TreeGrid;

    /// <summary>
    /// Gets the predefined <c>treeitem</c> attribute value. This role is used to identify an option item of a <c>tree</c> widget.
    /// </summary>
    public string TreeItem => HtmlAttributeValues.TreeItem;
}