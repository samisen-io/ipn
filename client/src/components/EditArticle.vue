<template>
  <div class="container">
    <div v-for="value in data" :key="value">
      <h1 class="mainHeading">EditArticle</h1>
      <div class="titleLabel">
        <label for="Title">Title :</label>
        <input type="text" id="Title" v-model="value.title" />
      </div>
      <div>
        <h1>geolocation</h1>
        <p>
          longitude:{{ coordinates.longitude }},latitude{{
            coordinates.latitude
          }}
        </p>
        <label for="Location">Location :</label>
        <input type="text" id="Location" v-model="value.Location" />
      </div>
      <div class="photosdiv">
        <h3>Upload u r Images and videos</h3>

        <label for="files">Select multiple files: </label>
        <input id="files" type="file" multiple />
        <output id="result" />
      </div>
      <div>
        <h1>ArticleTest</h1>
        <textarea class="articleBox" v-model="value.ArticleText"> </textarea>
      </div>
      <div class="divforbuttons">
        <button type="button">Save</button>
        <button type="button" class="buttonforPublish">Publish</button>
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
  data() {
    return {
      coordinates: {
        longitude: 0,
        latitude: 0,
      },
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
.mainHeading {
  font-family: "Lucida Console", "Courier New", monospace;
}
.titleLabel {
  margin-bottom: 30px;
}
.articleBox {
  height: 350px;
  width: 700px;
}
.buttonforPublish {
  margin-top: 20px;
  background-color: green;
}
.divforbuttons {
  text-align: center;
}

.thumbnail {
  padding: 10px;
  max-width: 25%;
  max-height: 350px;
  display: inline-block;
}
</style>