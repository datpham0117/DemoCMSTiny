tinymce.init({
    //content_style:
    //    "@import url('https://fonts.googleapis.com/css2?family=Lato:wght@900&family=Roboto&display=swap'); body { font-family: 'Roboto', sans-serif; } h1,h2,h3,h4,h5,h6 { font-family: 'Lato', sans-serif; }",
    selector: '#guidLine',
    plugins: 'print preview powerpaste casechange importcss tinydrive searchreplace autolink autosave save directionality advcode visualblocks visualchars fullscreen image link media mediaembed template codesample table charmap hr pagebreak nonbreaking anchor toc insertdatetime advlist lists checklist wordcount tinymcespellchecker a11ychecker imagetools textpattern noneditable help formatpainter permanentpen pageembed charmap tinycomments mentions quickbars linkchecker emoticons advtable export',
    mobile: {
        plugins: 'print preview powerpaste casechange importcss tinydrive searchreplace autolink autosave save directionality advcode visualblocks visualchars fullscreen image link media mediaembed template codesample table charmap hr pagebreak nonbreaking anchor toc insertdatetime advlist lists checklist wordcount tinymcespellchecker a11ychecker textpattern noneditable help formatpainter pageembed charmap mentions quickbars linkchecker emoticons advtable'
    },
    menu: {
        tc: {
            title: 'Comments',
            items: 'addcomment showcomments deleteallconversations'
        }
    },
    menubar: 'file edit view insert format tools table tc help',
    /*content_css: "/css/customfont.css",*/
    toolbar: 'undo redo | bold italic underline strikethrough | fontselect fontsizeselect formatselect | alignleft aligncenter alignright alignjustify | outdent indent |  numlist bullist checklist | forecolor backcolor casechange permanentpen formatpainter removeformat | pagebreak | charmap emoticons | fullscreen  preview save print | insertfile image quickimage  media pageembed template link anchor codesample | a11ycheck ltr rtl | showcomments addcomment | mybutton additem',
    autosave_ask_before_unload: true,
    autosave_interval: '30s',
    autosave_restore_when_empty: false,
    autosave_retention: '2m',
    image_advtab: true,
    images_upload_url: '/News/uploadImg',
    automatic_upload: true,
    importcss_append: true,
    template_cdate_format: '[Date Created (CDATE): %m/%d/%Y : %H:%M:%S]',
    template_mdate_format: '[Date Modified (MDATE): %m/%d/%Y : %H:%M:%S]',
    height: 600,
    image_caption: true,
    quickbars_selection_toolbar: 'bold italic | quicklink h2 h3 blockquote quickimage quicktable',
    noneditable_noneditable_class: 'mceNonEditable',
    toolbar_mode: 'sliding',
    spellchecker_ignore_list: ['Ephox', 'Moxiecode'],
    tinycomments_mode: 'embedded',
    font_formats:
        "Andale Mono=andale mono,times; Arial=arial,helvetica,sans-serif; Arial Black=arial black,avant garde; Book Antiqua=book antiqua,palatino; Comic Sans MS=comic sans ms,sans-serif; Courier New=courier new,courier; Georgia=georgia,palatino; Helvetica=helvetica; Impact=impact,chicago; Symbol=symbol; Tahoma=tahoma,arial,helvetica,sans-serif; Terminal=terminal,monaco; Times New Roman=times new roman,times; Trebuchet MS=trebuchet ms,geneva; Verdana=verdana,geneva; Webdings=webdings; Wingdings=wingdings,zapf dingbats; Lato Black=lato; Roboto=roboto; Oswald=oswald;",
    content_style: '.mymention{ color: gray; }' + "@import url('https://fonts.googleapis.com/css2?family=Oswald&display=swap');", 
    contextmenu: 'link image imagetools table configurepermanentpen',
    a11y_advanced_options: true,
    mentions_selector: '.mymention',
    mentions_item_type: 'profile',
    setup: function (editor) {
        var items = [
            {
                type: 'menuitem',
                text: 'Menu item 1',
                onAction: function () {
                    editor.insertContent('&nbsp;<em>You clicked menu item 1!</em>');
                }
            }
        ];

        editor.ui.registry.addButton('additem', {
            text: 'Add item',
            onAction: function () {
                items.push({
                    type: 'menuitem',
                    text: 'Menu item 2',
                    onAction: function () {
                        editor.insertContent('&nbsp;<em>You clicked menu item 2!</em>');
                    }
                });
            }
        });

        editor.ui.registry.addMenuButton('mybutton', {
            text: 'My button',
            fetch: function (callback) {
                callback(items);
            }
        });
    }
});