import { createWebHistory, createRouter } from "vue-router";
import SignIn from "../components/SignIn.vue"
import SignUp from "../components/SignUp.vue"
import CreateArticles from "../components/CreateArticles.vue"
import EditArticle from "../components/EditArticle.vue"
import NewsFeed from "../components/NewsFeed.vue"

const routes = [
    {
        path: "/",
        name: "SignIn",
        component: SignIn,

    },
    {
        path: "/signup",
        name: "SignUp",
        component: SignUp,

    },
    {
        path: "/createarticles",
        name: "CreateArticles",
        component: CreateArticles,

    },
    {
        path: "/editarticle/:ArticleName",
        name: "EditArticle",
        component: EditArticle,
    },
    {
        path: "/newsfeed",
        name: "NewsFeed",
        component: NewsFeed
    }

];

const router = createRouter({
    history: createWebHistory(),
    routes,
});

export default router;