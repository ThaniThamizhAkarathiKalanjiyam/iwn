$(document).ready(function(){
	
	$("#btnSearch").click(function(){
		 $.ajax({
				url: '../wn_synset/entity',
				type: 'POST',
				dataType: 'json',
				data: {},
				success: function (ResponseJsonE) {
					
				},
				error: function () {
					//$dfd.reject();
				}
			});
	})
	
})