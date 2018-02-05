function createCommentItem(form, path) {
debugger
    var service = new ItemService({ url: '/sitecore/api/ssc/item' });
    var obj = {
        ItemName: 'comment - ' + form.name.value,
        TemplateID: '{17730FFD-14FB-44B1-ABEC-A3B6A60F1A7C}',
        Name: form.name.value,
        Comment: form.comment.value
    };
    sevice.create(obj).path(path).execute().then(function (item) {
        form.name.value = form.comment.value = '';
        window.alert('Thanks. Your message will show on the site shortly')
    }).fail(function (err) {
        window.alert(err);
        });
    event.preventDefault();
    return false;
}