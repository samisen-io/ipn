import { createWebHistory, createRouter } from "vue-router";
import SignIn from "../components/SignIn.vue"
import SignUp from "../components/SignUp.vue"
import CreateArticles from "../components/CreateArticles.vue"
import EditArticle from "../components/EditArticle.vue"
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
        path: "/createArticles",
        name: "CreateArticles",
        component: CreateArticles,

    },
    {
        path: "/editArticle",
        name: "EditArticle",
        component: EditArticle,
    }

];

const router = createRouter({
    history: createWebHistory(),
    routes,
});

export default router;