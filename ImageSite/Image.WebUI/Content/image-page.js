

$(document).ready(function(){
    var li_count=@Model.ImagePageInfo.TotalPages;
    if(li_count>10)
    {
        for(var i=7 ; i<li_count;i++)
        {
            $('.content_right nav ul li:eq('+i+')').hide();
        }
        $('.content_right nav ul li:eq(6)').after("<li><span>...</span></li>")
    }

    $('.content_left nav ul li:first').click(function(){
        if(@Model.FolderPageInfo.CurrentPage!=1)
        {
            var folderPage=@Model.FolderPage-1;
            var folderId=@Model.FolderId;
            var imagePage=@Model.FolderPageInfo.CurrentPage;
            location.href = "/?folderPage="+folderPage+"&folderId="+folderId+"&imagePage="+imagePage;
        }
    });

    $('.content_left nav ul li:last').click(function(){
        if(@Model.FolderPageInfo.CurrentPage==@Model.FolderPageInfo.TotalPages)
        {
            var folderPage=@Model.FolderPage+1;
            var folderId=@Model.FolderId;
            var imagePage=@Model.FolderPageInfo;
            location.href = "/?folderPage="+folderPage+"&folderId="+folderId+"&imagePage="+imagePage;
        }
    });

    $(".content_right nav ul li:first").click(function(){
        if(@Model.ImagePageInfo.CurrentPage!=1)
        {
            var folderPage=@Model.FolderPage;
            var folderId=@Model.FolderId;
            var imagePage=@Model.ImagePageInfo.CurrentPage-1;
            location.href = "/?folderPage="+folderPage+"&folderId="+folderId+"&imagePage="+imagePage;
        }
    });

    $(".content_right nav ul li:last").click(function(){
        if(@Model.ImagePageInfo.CurrentPage!=@Model.ImagePageInfo.TotalPages)
        {
            var folderPage=@Model.FolderPage;
            var folderId=@Model.FolderId;
            var imagePage=@Model.ImagePageInfo.CurrentPage+1;
            location.href = "/?folderPage="+folderPage+"&folderId="+folderId+"&imagePage="+imagePage;
        }
    });
});





<script type="text/javascript">
    $(document).ready(function(){
        var li_count=@Model.ImagePageInfo.TotalPages;
        if(li_count>10)
        {
            for(var i=7 ; i<li_count;i++)
            {
                $('.content_right nav ul li:eq('+i+')').hide();
            }
            $('.content_right nav ul li:eq(6)').after("<li><span>...</span></li>")
        }

        @*$('.content_left nav ul li:first').click(function(){
            if(@Model.FolderPageInfo.CurrentPage!=1)
            {
                var folderPage=@Model.FolderPage-1;
                var folderId=@Model.FolderId;
                var imagePage=@Model.FolderPageInfo.CurrentPage;
                location.href = "/?folderPage="+folderPage+"&folderId="+folderId+"&imagePage="+imagePage;
            }
        });

        $('.content_left nav ul li:last').click(function(){
            if(@Model.FolderPageInfo.CurrentPage==@Model.FolderPageInfo.TotalPages)
            {
                var folderPage=@Model.FolderPage+1;
                var folderId=@Model.FolderId;
                var imagePage=@Model.FolderPageInfo;
                location.href = "/?folderPage="+folderPage+"&folderId="+folderId+"&imagePage="+imagePage;
            }
        });

        $(".content_right nav ul li:first").click(function(){
            if(@Model.ImagePageInfo.CurrentPage!=1)
            {
                var folderPage=@Model.FolderPage;
                var folderId=@Model.FolderId;
                var imagePage=@Model.ImagePageInfo.CurrentPage-1;
                location.href = "/?folderPage="+folderPage+"&folderId="+folderId+"&imagePage="+imagePage;
            }
        });

        $(".content_right nav ul li:last").click(function(){
            if(@Model.ImagePageInfo.CurrentPage!=@Model.ImagePageInfo.TotalPages)
            {
                var folderPage=@Model.FolderPage;
                var folderId=@Model.FolderId;
                var imagePage=@Model.ImagePageInfo.CurrentPage+1;
                location.href = "/?folderPage="+folderPage+"&folderId="+folderId+"&imagePage="+imagePage;
            }
        });*@
        });

</script>