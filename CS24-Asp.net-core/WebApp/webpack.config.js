const path = require('path');
const MiniCssExtractPlugin = require('mini-css-extract-plugin');
const postcssPresetEnv = require('postcss-preset-env');

// We are getting 'process.env.NODE_ENV' from the NPM scripts
// Remember the 'dev' script?
const devMode = process.env.NODE_ENV !== 'production';

module.exports = {
    // Thiết lập chế độ tối ưu, mặc định là tối ưu production
    mode: devMode ? 'development' : 'production',

    // Các file nguồn SCSS ['file1', 'file2']
    entry: ['./scss/site.scss'],

    output: {

        path: path.resolve(__dirname, 'wwwroot'), // Đường dẫn thư mục gốc lưu kết quả

        // Thư mục nơi lưu kết quả biên dịch (wwwwroot/css)
        publicPath: '/css',

        // Nơi lưu bundle './wwwroot/js/sas.js' (file chạy để xuất css)
        filename: 'js/sass.js'
    },
    module: {
        rules: [
            {
                // Thiết lập build scss
                test: /\.(sa|sc)ss$/,
                use: [
                    {
                        loader: MiniCssExtractPlugin.loader
                    },
                    {
                        // Interprets CSS
                        loader: 'css-loader',
                        options: {
                            importLoaders: 2
                        }
                    },
                    {
                        // minify CSS và thêm autoprefix
                        loader: 'postcss-loader', 
                        options: {
                            ident: 'postcss',

                            // Đặt chế độ tối ưu
                            plugins: devMode
                                ? () => []
                                : () => [
                                    postcssPresetEnv({
                                        browsers: ['>1%']
                                    }),
                                    require('cssnano')()
                                ]
                        }
                    },
                    {
                        loader: 'sass-loader'
                    }
                ]
            },
            {
                // Thiết lập nạp image cho css
                test: /\.(png|jpe?g|gif)$/,
                use: [
                    {
                        loader: 'file-loader',
                        options: {
                            name: '[name].[ext]',
                            // Image sử dụng bởi CSS lưu tại
                            publicPath: '../images',
                            emitFile: false
                        }
                    }
                ]
            }
        ]
    },
    plugins: [
        // Xuất kết quả với MiniSCSS
        new MiniCssExtractPlugin({
            filename: devMode ? 'css/site.css' : 'css/site.min.css'
        })
    ]
};
