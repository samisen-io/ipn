<template>
  <div class="container">
    <div v-for="value in data" :key="value">
      <h1 class="mainHeading">Edit Article</h1>

      <div class="mb-4 row">
        <label for="staticEmail" class="col-sm-1 col-form-label">Title:</label>
        <div class="col-sm-3">
          <input
            type="text"
            class="form-control"
            placeholder="Title For An News Article"
          />
        </div>
      </div>

      <div class="mb-2 row">
        <label for="Location" class="col-sm-1 col-form-label">Location:</label>
        <div class="col-sm-3">
          <input
            disabled
            type="text"
            class="form-control"
            placeholder="Location"
            v-model="value.Location"
          />
        </div>
      </div>

      <div class="inline">
        <h3>Upload u r Images and videos</h3>
        <input id="files" type="file" multiple />
        <output id="result" />
      </div>

      <div class="form-floating">
        <h1 class="headingForAnArticle">ArticleText</h1>
        <textarea
          class="form-control"
          placeholder="Leave a comment here"
          id="floatingTextarea2"
          style="height: 400px"
          v-model="value.ArticleText"
        ></textarea>
      </div>
      <div class="divforbuttons">
        <button type="button" class="btn btn-primary">Publish</button>&nbsp;
        <button type="button" class="btn btn-success">Save</button>
      </div>
    </div>
  </div>
</template>

<script>
window.onload = function () {
  if (window.File && window.FileList && window.FileReader) {
    var filesInput = document.getElementById("files");
    filesInput.addEventListener("change", function (event) {
      var files = event.target.files;
      var output = document.getElementById("result");
      for (var i = 0; i < files.length; i++) {
        var file = files[i];

        if (file.type.match("image")) {
          var picReader = new FileReader();
          picReader.addEventListener("load", function (event) {
            var picFile = event.target;
            var div = document.createElement("div");
            div.innerHTML =
              "<img class='thumbnail' src='" +
              picFile.result +
              "'" +
              "title='" +
              picFile.name +
              "'/>";

            output.insertBefore(div, null);
          });

          picReader.readAsDataURL(file);
        } else if (file.type.match("video")) {
          let reader = new FileReader();
          reader.readAsArrayBuffer(file);
          reader.onload = function (e) {
            let buffer = e.target.result;
            let videoBlob = new Blob([new Uint8Array(buffer)], {
              type: "video/mp4",
            });
            let url = window.URL.createObjectURL(videoBlob);

            var div = document.createElement("div");
            div.innerHTML =
              "<video class='thumbnail' controls>'" +
              "<source src='" +
              url +
              "'" +
              " type='video/mp4'>'" +
              "</video>";
            output.insertBefore(div, null);
          };
          picReader.readAsDataURL(file);
        }
      }
    });
  } else {
    console.log("");
  }
};

export default {
  created() {
    this.$getLocation({}).then((coordinates) => {
      this.coordinates = coordinates;
      console.log(coordinates);
    });
  },
  data() {
    return {
      data: [
        {
          image: "",
          title: "Samsung",
          Location: "Banglore",
          ArticleText:
            "At w3schools.com you will learn how to make a website. They offer free tutorials in all web development technologies.  At w3schools.com you will learn how to make a website. They offer free tutorials in all web development technologies.  At w3schools.com you will learn how to make a website. They offer free tutorials in all web development technologies.  At w3schools.com you will learn how to make a website. They offer free tutorials in all web development technologies.  At w3schools.com you will learn how to make a website. They offer free tutorials in all web development technologies.  At w3schools.com you will learn how to make a website. They offer free tutorials in all web development technologies.  At w3schools.com you will learn how to make a website. They offer free tutorials in all web development technologies.  At w3schools.com you will learn how to make a website. They offer free tutorials in all web development technologies.  At w3schools.com you will learn how to make a website. They offer free tutorials in all web development technologies.  At w3schools.com you will learn how to make a website. They offer free tutorials in all web development technologies.  At w3schools.com you will learn how to make a website. They offer free tutorials in all web development technologies.  At w3schools.com you will learn how to make a website. They offer free tutorials in all web development technologies.  At w3schools.com you will learn how to make a website. They offer free tutorials in all web development technologies.  At w3schools.com you will learn how to make a website. They offer free tutorials in all web development technologies.  At w3schools.com you will learn how to make a website. They offer free tutorials in all web development technologies.  At w3schools.com you will learn how to make a website. They offer free tutorials in all web development technologies.  At w3schools.com you will learn how to make a website. They offer free tutorials in all web development technologies.  At w3schools.com you will learn how to make a website. They offer free tutorials in all web development technologies.  At w3schools.com you will learn how to make a website. They offer free tutorials in all web development technologies.  At w3schools.com you will learn how to make a website. They offer free tutorials in all web development technologies.  At w3schools.com you will learn how to make a website. They offer free tutorials in all web development technologies.  At w3schools.com you will learn how to make a website. They offer free tutorials in all web development technologies.  At w3schools.com you will learn how to make a website. They offer free tutorials in all web development technologies.  At w3schools.com you will learn how to make a website. They offer free tutorials in all web development technologies.  At w3schools.com you will learn how to make a website. They offer free tutorials in all web development technologies.",
        },
      ],
    };
  },
};
</script>

<style>
.divforbuttons {
  margin-top: 30px;
  margin-bottom: 20px;
  text-align: right;
}
.headingForAnArticle {
  font-family: 'Times New Roman', Times, serif;
  color: black;
  margin-top: 30px;
  margin-bottom: 20px;
  text-align: center;
}
.mainHeading {
   margin-top: 5px;
  margin-bottom: 20px;
  text-align: center;
 
}
.titleLabel {
  margin-bottom: 30px;

  float: left;
}

.thumbnail {
  content: "";
  clear: both;
  display: table;
  padding: 10px;
  max-width: 55%;
  max-height: 450px;
  display: inline-block;
}
.inline {
   margin-top: 15px;
   margin-bottom: 20px;
  display: inline-block;
}
</style>