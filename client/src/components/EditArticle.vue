<template>
  <div class="container">
    <div v-for="value in data" :key="value">
      <h1 class="mainHeading">Edit Article</h1>
      <div class="titleLabel">
        <label for="Title" class="form-label">Title:</label>
        <input
          type="text"
          class="form-control"
          id="Title"
          placeholder="Title For An News Article"
          v-model="value.title"
        />
      </div>
      <div>
        <div class="titleLabel">
          <label for="Location" class="form-label">Location:</label>
          <input
            type="text"
            class="form-control"
            id="Location"
            placeholder="Location"
            v-model="value.Location"
          />
        </div>
      </div>

      <h3>Upload u r Images and videos</h3>
      <input id="files" type="file" multiple />
      <output id="result" />

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
      var div = document.createElement("div").classList.add("thumbnail");
    
      for (var i = 0; i < files.length; i++) {
        var file = files[i];

        if (file.type.match("image")) {
          var picReader = new FileReader();
          picReader.addEventListener("load", function (event) {
            var picFile = event.target;
            if (div.innerHTML == undefined) {
              div.innerHTML = 
              "<img  src='" +
              picFile.result +
              "'" +
              "title='" +
              picFile.name +
              "'/>";
            } else {
                div.innerHTML = div.innerHTML +
              "<img  src='" +
              picFile.result +
              "'" +
              "title='" +
              picFile.name +
              "'/>";
            }
            
          });
          // output.insertBefore(div, null);
          picReader.readAsDataURL(file);
        } else if (file.type.match("video")) {
          // let reader = new FileReader();
          // reader.readAsArrayBuffer(file);
          // reader.onload = function (e) {
          //   let buffer = e.target.result;
          //   let videoBlob = new Blob([new Uint8Array(buffer)], {
          //     type: "video/mp4",
          //   });
          //   let url = window.URL.createObjectURL(videoBlob);

          //   var div = document.createElement("div");
          //   div.innerHTML =
          //     "<video class='thumbnail' controls>'" +
          //     "<source src='" +
          //     url +
          //     "'" +
          //     " type='video/mp4'>'" +
          //     "</video>";
          //   output.insertBefore(div, null);
          // };
          // picReader.readAsDataURL(file);
        }
        output.appendChild(div);
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
.headingForAnArticle {
  margin-top: 30px;
  margin-bottom: 20px;
  text-align: center;
}
.mainHeading {
  display: block;
}
.titleLabel {
  margin-bottom: 30px;
}
.divforbuttons{
  text-align: right;
}
.thumbnail {
  padding: 10px;
  max-width: 35%;
  max-height: 450px;
}
</style>