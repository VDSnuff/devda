import React, { Component } from 'react';
import '../css/custom.css'

export class PostView extends Component {
    static displayName = PostView.name;

    constructor(props) {
        super(props);
        this.state = { posts: [], loading: true };
      
        fetch('api/post')
            .then(response => response.json())
            .then(data => {
                this.setState({ posts: data, loading: false });
            });
    }

    static renderPostsView(posts) {
        return (
            <div>
                {posts.map(post =>
                    <div className="post" key={post.PostId}>
                        <h2>{post.Title}</h2>
                        <div className="authorBlock"><img alt="Avatar" src={post.User.Avatar} /> {post.User.Name} {post.User.Surname},<br /> {post.CreationDay}</div>
                        <p className="postText">{post.Content}</p>
                    </div>
                )}
            </div>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : PostView.renderPostsView(this.state.posts);

        return (
            <div>
                {contents}
            </div>
        );
    }
}
