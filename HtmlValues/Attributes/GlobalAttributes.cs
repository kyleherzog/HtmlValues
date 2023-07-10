namespace HtmlValues.Attributes
{
    public class GlobalAttributes
    {
        /// <summary>
        /// Gets the name of the <c>accesskey</c> attribute
        /// </summary>
        public string AccessKey => HtmlAttributes.AccessKey;

        /// <summary>
        /// Gets the name of the <c>autocapitalize</c> attribute.
        /// </summary>
        public string AutoCapitalize => HtmlAttributes.AutoCapitalize;

        /// <summary>
        /// Gets the name of the <c>autofocus</c> attribute.
        /// </summary>
        public string AutoFocus => HtmlAttributes.AutoFocus;

        /// <summary>
        /// Gets the name of the <c>class</c> attribute.
        /// </summary>
        public string Class => HtmlAttributes.Class;

        /// <summary>
        /// Gets the name of the <c>contenteditable</c> attribute.
        /// </summary>
        public string ContentEditable => HtmlAttributes.ContentEditable;

        /// <summary>
        /// Gets the name of the <c>dir</c> attribute.
        /// </summary>
        public string Dir => HtmlAttributes.Dir;

        /// <summary>
        /// Gets the name of the <c>draggable</c> attribute.
        /// </summary>
        public string Draggable => HtmlAttributes.Draggable;

        /// <summary>
        /// Gets the name of the <c>enterkeyhint</c> attribute.
        /// </summary>
        public string EnterKeyHint => HtmlAttributes.EnterKeyHint;

        /// <summary>
        /// Gets the name of the <c>hidden</c> attribute.
        /// </summary>
        public string Hidden => HtmlAttributes.Hidden;

        /// <summary>
        /// Gets the name of the <c>id</c> attribute.
        /// </summary>
        public string Id => HtmlAttributes.Id;

        /// <summary>
        /// Gets the name of the <c>Inert</c> attribute.
        /// </summary>
        public string Inert => HtmlAttributes.Inert;

        /// <summary>
        /// Gets the name of the <c>inputmode</c> attribute.
        /// </summary>
        public string InputMode => HtmlAttributes.InputMode;

        /// <summary>
        /// Gets the name of the <c>is</c> attribute.
        /// </summary>
        public string Is => HtmlAttributes.Is;

        /// <summary>
        /// Gets the name of the <c>itemid</c> attribute.
        /// </summary>
        public string ItemId => HtmlAttributes.ItemId;

        /// <summary>
        /// Gets the name of the <c>itemprop</c> attribute.
        /// </summary>
        public string ItemProp => HtmlAttributes.ItemProp;

        /// <summary>
        /// Gets the name of the <c>itemref</c> attribute.
        /// </summary>
        public string ItemRef => HtmlAttributes.ItemRef;

        /// <summary>
        /// Gets the name of the <c>itemscope</c> attribute.
        /// </summary>
        public string ItemScope => HtmlAttributes.ItemScope;

        /// <summary>
        /// Gets the name of the <c>itemtype</c> attribute.
        /// </summary>
        public string ItemType => HtmlAttributes.ItemType;

        /// <summary>
        /// Gets the name of the <c>lang</c> attribute.
        /// </summary>
        public string Lang => HtmlAttributes.Lang;

        /// <summary>
        /// Gets the name of the <c>Part</c> attribute.
        /// </summary>
        public string Part => HtmlAttributes.Part;

        /// <summary>
        /// Gets the name of the <c>Role</c> attribute.
        /// </summary>
        public string Role => HtmlAttributes.Role;

        /// <summary>
        /// Gets the name of the <c>slot</c> attribute.
        /// </summary>
        public string Slot => HtmlAttributes.Slot;

        /// <summary>
        /// Gets the name of the <c>spellcheck</c> attribute.
        /// </summary>
        public string SpellCheck => HtmlAttributes.SpellCheck;

        /// <summary>
        /// Gets the name of the <c>style</c> attribute.
        /// </summary>
        public string Style => HtmlAttributes.Style;

        /// <summary>
        /// Gets the name of the <c>tabindex</c> attribute.
        /// </summary>
        public string TabIndex => HtmlAttributes.TabIndex;

        /// <summary>
        /// Gets the name of the <c>title</c> attribute.
        /// </summary>
        public string Title => HtmlAttributes.Title;

        /// <summary>
        /// Gets the name of the <c>translate</c> attribute.
        /// </summary>
        public string Translate => HtmlAttributes.Translate;

        /// <summary>
        /// Gets the name of the specified <c>data-</c> prefixed attribute
        /// </summary>
        /// <param name="name">The data attribute name that is to be prefixed with <c>data-</c>.</param>
        /// <returns>The full data attribute name.</returns>
        public string Data(string name) => $"{HtmlAttributes.Data}-{name}";
    }
}