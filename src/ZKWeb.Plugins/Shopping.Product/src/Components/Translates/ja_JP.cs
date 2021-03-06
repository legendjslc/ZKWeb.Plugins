﻿using System.Collections.Generic;
using ZKWeb.Localize;
using ZKWebStandard.Extensions;
using ZKWebStandard.Ioc;

namespace ZKWeb.Plugins.Shopping.Product.src.Components.Translates {
	/// <summary>
	/// 日本语翻译
	/// </summary>
	[ExportMany, SingletonReuse]
	public class ja_JP : ITranslateProvider {
		private static HashSet<string> Codes = new HashSet<string>() { "ja-JP" };
		private static Dictionary<string, string> Translates = new Dictionary<string, string>()
		{
			{ "Product", "商品" },
			{ "ProductManage", "商品管理" },
			{ "Product management for ec site", "オンラインショッピングサイトが使う商品管理機能" },
			{ "ProductType", "商品タイプ" },
			{ "RealProduct", "実体のある商品" },
			{ "VirtualProduct", "バーチャル商品" },
			{ "ProductState", "商品状態" },
			{ "OnSale", "発売中" },
			{ "StopSelling", "発売停止" },
			{ "WaitForSales", "発売予定" },
			{ "ProductClass", "商品クラス" },
			{ "ProductTag", "商品タグ" },
			{ "Price", "価格" },
			{ "Stock", "ストック" },
			{ "Seller", "販売者" },
			{ "ProductAlbumSettings", "商品アルバム設定" },
			{ "ProductSettings", "商品設定" },
			{ "OriginalImageWidth", "オリジナル画像の幅" },
			{ "OriginalImageHeight", "オリジナル画像の高さ" },
			{ "ThumbnailImageWidth", "サムネイル画像の幅" },
			{ "ThumbnailImageHeight", "サムネイル画像の高さ" },
			{ "ProductAlbum", "商品アルバム" },
			{ "ProductProperties", "規格属性" },
			{ "ProductPriceAndStock", "価格ストック" },
			{ "ProductIntroduction", "商品紹介" },
			{ "As Main Image", "メイン画像にする" },
			{ "Clear", "クリア" },
			{ "Uploaded pictures will be scaled to {0}x{1}, " +
				"upload pictures of this size can achieve the best display effect",
				"アップロードされた画像は{0}x{1}にスケールされます、このサイズの画像をアップロードすると最良な効果が得られます" },
			{ "Category", "カテゴリ" },
			{ "Category not exists", "カテゴリが存在しない" },
			{ "NonSalesProperties", "属性" },
			{ "SalesProperties", "規格" },
			{ "Sure to change category? The properties you selected will lost!",
				"カテゴリの変更を続行しますか？現在選んだ規格と属性はリセットされます！"},
			{ "Condition", "条件" },
			{ "Default", "デフォルト" },
			{ "Order count >=", "注文数 >=" },
			{ "InhertIfEmpty", "空の場合は継承する" },
			{ "PriceCurrency", "価格の貨幣" },
			{ "OrderCountGE", "注文数 >=" },
			{ "All", "全部" },
			{ "Weight", "重量" },
			{ "Weight(g)", "重量(グラム)" },
			{ "ProductList", "商品リスト" },
			{ "Preview", "プレビュー" },
			{ "The product you are visiting does not exist.", "ご覧の商品は存在しません。" },
			{ "Brand", "ブランド" },
			{ "ModelNumber", "モデル番号" },
			{ "{0:F2} gram", "{0:F2} グラム(g)" },
			{ "{0:F2}~{1:F2} gram", "{0:F2}~{1:F2} グラム(g)" },
			{ "BestSales", "ベストセールス" },
			{ "LowerPrice", "より低い価格" },
			{ "HigherPrice", "より高い価格" },
			{ "NewestOnSale", "最新販売中" },
			{ "FilterByPrice", "価格フィルタを適用" },
			{ "ProductListSettings", "商品リスト設定" },
			{ "ProductsPerPage", "ページごとに表示する商品数" },
			{ "Please enter product name", "商品名を入力してください" },
			{ "All Products", "商品一覧" },
			{ "No matching products found, please change the condition and search again.",
				"条件に合った商品が見つかりません、条件を変えて再度検索してください。"},
			{ "ProductProperty", "商品属性" },
			{ "ProductPropertyManage", "商品属性管理" },
			{ "ProductCategory", "商品カテゴリ" },
			{ "ProductCategoryManage", "商品カテゴリ管理" },
			{ "IsSalesProperty", "規格か" },
			{ "PropertyValues", "属性値" },
			{ "ControlType", "コントロールタイプ" },
			{ "TextBox", "テキストボックス" },
			{ "CheckBox", "チェックボックス" },
			{ "RadioButton", "ラジオボタン" },
			{ "DropdownList", "ドロップダウンリスト" },
			{ "EditableDropdownList", "編集可能なドロップダウンリスト" },
			{ "OrderCount", "注文数" },
			{ "Product is OnSale", "この商品は販売中です" },
			{ "Product is StopSelling", "この商品の販売は終了しました" },
			{ "Product is WaitForSales", "この商品の販売はまだ始まっていません" },
			{ "Seller username not exist", "出品者のユーザー名は存在しません" },
			{ "Shop Manage", "ショップ管理" }
		};

		public bool CanTranslate(string code) {
			return Codes.Contains(code);
		}

		public string Translate(string text) {
			return Translates.GetOrDefault(text);
		}
	}
}
