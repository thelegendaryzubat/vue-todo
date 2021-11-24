module.exports = {
  devServer: {
    proxy: {
      '^/todo': {
        target: 'https://localhost:5001',
        changeOrigin: true
      },
    }
  }
}
