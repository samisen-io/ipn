import { HttpContextContract } from '@ioc:Adonis/Core/HttpContext'
import mongoose, { Schema } from 'mongoose'


// Create cat model
const Article = mongoose.model('Article', new Schema({
    title: String,
    text: String,
}))


export default class ArticlesController {


    public async list({ }: HttpContextContract) {

    }


    public async create({ }: HttpContextContract) {

    }
}
