﻿using Microsoft.EntityFrameworkCore;
namespace QuickMasterRazor.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MyContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MyContext>>()))
        {
            if (context == null || context.Book == null)
            {
                throw new ArgumentNullException("Null QuickMasterRazorContext");
            }

            // Look for any movies.
            if (context.Book.Any())
            {
                return;   // DB has been seeded
            }

            context.Book.AddRange(
                new Book
                {
                    Title = "８の殺人 【新装版】",
                    Price = 713,
                    Publisher = "講談社",
                },

                new Book
                {
                    Title = "闇の喇叭（空閑純シリーズ１）",
                    Price = 671,
                    Publisher = "講談社",
                },

                new Book
                {
                    Title = "死神の浮力（死神シリーズ２）",
                    Price = 858,
                    Publisher = "文藝春秋",
                },

                new Book
                {
                    Title = "人形の部屋",
                    Price = 858,
                    Publisher = "東京創元社",
                },

                new Book
                {
                    Title = "親不孝通りディテクティブ",
                    Price = 649,
                    Publisher = "講談社",
                },

                new Book
                {
                    Title = "ウェディング・ドレス",
                    Price = 838,
                    Publisher = "講談社",
                },

                new Book
                {
                    Title = "桜姫",
                    Price = 565,
                    Publisher = "角川書店",
                },

                new Book
                {
                    Title = "天使はモップを持って　（女清掃員探偵　キリコシリーズ１）",
                    Price = 723,
                    Publisher = "文芸春秋",
                },

                new Book
                {
                    Title = "鏡の中は日曜日",
                    Price = 859,
                    Publisher = "講談社",
                },

                new Book
                {
                    Title = "ＱＥＤ　伊勢の曙光",
                    Price = 979,
                    Publisher = "講談社",
                },

                new Book
                {
                    Title = "仮面病棟",
                    Price = 652,
                    Publisher = "実業之日本社",
                },

                new Book
                {
                    Title = "聯愁殺",
                    Price = 838,
                    Publisher = "中央公論新社",
                },

                new Book
                {
                    Title = "アコギなのかリッパなのか（佐倉聖の事件簿シリーズ１）",
                    Price = 605,
                    Publisher = "新潮社",
                },

                new Book
                {
                    Title = "殺人ウイルスを追え",
                    Price = 682,
                    Publisher = "光文社",
                },

                new Book
                {
                    Title = "完全恋愛",
                    Price = 901,
                    Publisher = "小学館",
                },

                new Book
                {
                    Title = "殺人の祭壇",
                    Price = 713,
                    Publisher = "双葉社",
                },

                new Book
                {
                    Title = "虚夢",
                    Price = 692,
                    Publisher = "講談社",
                },

                new Book
                {
                    Title = "私という名の変奏曲",
                    Price = 770,
                    Publisher = "文藝春秋",
                },

                new Book
                {
                    Title = "舞田ひとみ１１歳、ダンスときどき探偵（舞田ひとみシリーズ１）",
                    Price = 755,
                    Publisher = "光文社",
                },

                new Book
                {
                    Title = "刑事失格",
                    Price = 836,
                    Publisher = "東京創元社",
                },

                new Book
                {
                    Title = "廉恥－警視庁強行犯係・樋口顕－",
                    Price = 715,
                    Publisher = "幻冬舎",
                },

                new Book
                {
                    Title = "和気有町屋南部署",
                    Price = 704,
                    Publisher = "徳間書店",
                },

                new Book
                {
                    Title = "ＯＮＥ　（猟奇犯罪捜査班・藤堂比奈子６）",
                    Price = 616,
                    Publisher = "ＫＡＤＯＫＡＷＡ",
                },

                new Book
                {
                    Title = "体育館の殺人（裏染天馬シリーズ１）",
                    Price = 858,
                    Publisher = "東京創元社",
                },

                new Book
                {
                    Title = "文化祭オクロック",
                    Price = 792,
                    Publisher = "東京創元社",
                },

                new Book
                {
                    Title = "昨日まで不思議の校舎（市立高校シリーズ６）",
                    Price = 748,
                    Publisher = "東京創元社",
                },

                new Book
                {
                    Title = "月光",
                    Price = 713,
                    Publisher = "中央公論新社",
                },

                new Book
                {
                    Title = "リロ・グラ・シスタ",
                    Price = 682,
                    Publisher = "光文社",
                },

                new Book
                {
                    Title = "七つの会議",
                    Price = 880,
                    Publisher = "集英社",
                },

                new Book
                {
                    Title = "冤罪死刑",
                    Price = 825,
                    Publisher = "講談社",
                },

                new Book
                {
                    Title = "トッカンｖｓ勤労商工会",
                    Price = 836,
                    Publisher = "早川書房",
                },

                new Book
                {
                    Title = "灰色の虹",
                    Price = 979,
                    Publisher = "新潮社",
                },

                new Book
                {
                    Title = "空飛ぶ広報室",
                    Price = 847,
                    Publisher = "幻冬舎",
                },

                new Book
                {
                    Title = "三匹のおっさんふたたび（三匹のおっさんシリーズ２）",
                    Price = 781,
                    Publisher = "新潮社",
                },

                new Book
                {
                    Title = "ラッシュライフ",
                    Price = 692,
                    Publisher = "新潮社",
                },

                new Book
                {
                    Title = "君に訣別の時を",
                    Price = 681,
                    Publisher = "集英社",
                },

                new Book
                {
                    Title = "花妖譚",
                    Price = 440,
                    Publisher = "文藝春秋",
                },

                new Book
                {
                    Title = "小説　君の名は。",
                    Price = 616,
                    Publisher = "ＫＡＤＯＫＡＷＡ",
                },

                new Book
                {
                    Title = "小説　言の葉の庭",
                    Price = 748,
                    Publisher = "ＫＡＤＯＫＡＷＡ",
                },

                new Book
                {
                    Title = "ボーダーライン",
                    Price = 880,
                    Publisher = "集英社",
                },

                new Book
                {
                    Title = "アクセス",
                    Price = 692,
                    Publisher = "新潮社",
                },

                new Book
                {
                    Title = "望郷",
                    Price = 605,
                    Publisher = "文藝春秋",
                },

                new Book
                {
                    Title = "ふしぎな図書館",
                    Price = 565,
                    Publisher = "講談社",
                },

                new Book
                {
                    Title = "クライマーズ・ハイ",
                    Price = 692,
                    Publisher = "文藝春秋",
                },

                new Book
                {
                    Title = "叱る、だけど怒らない",
                    Price = 545,
                    Publisher = "光文社",
                },

                new Book
                {
                    Title = "マンボウ最後の大バクチ",
                    Price = 440,
                    Publisher = "新潮社",
                },

                new Book
                {
                    Title = "自分の心も好きになりたい",
                    Price = 734,
                    Publisher = "角川書店",
                },

                new Book
                {
                    Title = "「断わる力」を身につける！",
                    Price = 572,
                    Publisher = "集英社",
                },

                new Book
                {
                    Title = "司馬遼太郎と城を歩く",
                    Price = 734,
                    Publisher = "光文社",
                },

                new Book
                {
                    Title = "ドラコニア綺譚集",
                    Price = 638,
                    Publisher = "河出書房新社",
                },

                new Book
                {
                    Title = "最低で最高の本屋",
                    Price = 586,
                    Publisher = "集英社",
                },

                new Book
                {
                    Title = "意味がなければスイングはない",
                    Price = 597,
                    Publisher = "文藝春秋",
                },

                new Book
                {
                    Title = "夢を見るために毎朝僕は目覚めるのです　村上春樹インタビュー集１９９７－２０１１",
                    Price = 880,
                    Publisher = "文藝春秋",
                },

                new Book
                {
                    Title = "権益の侵（町奉行内与力奮闘記３）",
                    Price = 715,
                    Publisher = "幻冬舎",
                },

                new Book
                {
                    Title = "天地明察",
                    Price = 607,
                    Publisher = "角川書店",
                },

                new Book
                {
                    Title = "三国志読本",
                    Price = 628,
                    Publisher = "角川春樹事務所",
                },

                new Book
                {
                    Title = "泣き童子　三島屋変調百物語参之続",
                    Price = 836,
                    Publisher = "角川書店",
                },

                new Book
                {
                    Title = "忍びの国",
                    Price = 607,
                    Publisher = "新潮社",
                },

                new Book
                {
                    Title = "魔法少女育成計画ＡＣＥＳ",
                    Price = 748,
                    Publisher = "宝島社",
                },

                new Book
                {
                    Title = "神獄塔メアリスケルター",
                    Price = 627,
                    Publisher = "ＫＡＤＯＫＡＷＡ",
                },

                new Book
                {
                    Title = "とある魔術のヘヴィーな座敷童が簡単な殺人妃の婚活事情",
                    Price = 715,
                    Publisher = "ＫＡＤＯＫＡＷＡ",
                },

                new Book
                {
                    Title = "かんぱに☆ガールズ　社長！！またまた出撃のお時間です！",
                    Price = 748,
                    Publisher = "ＫＡＤＯＫＡＷＡ",
                },

                new Book
                {
                    Title = "ブラス・オブ・シェルオール",
                    Price = 638,
                    Publisher = "ＫＡＤＯＫＡＷＡ",
                },

                new Book
                {
                    Title = "最後の魔王の戦記",
                    Price = 704,
                    Publisher = "講談社",
                },

                new Book
                {
                    Title = "再び始まる反救世譚（エスカトラ）",
                    Price = 638,
                    Publisher = "ＫＡＤＯＫＡＷＡ",
                },

                new Book
                {
                    Title = "ラエティティア覇竜戦記　神王のゲーム",
                    Price = 702,
                    Publisher = "ホビージャパン",
                },

                new Book
                {
                    Title = "魔術楽譜（グリモワール）の盾",
                    Price = 638,
                    Publisher = "ＫＡＤＯＫＡＷＡ",
                },

                new Book
                {
                    Title = "死線世界の追放者（リジェクター）",
                    Price = 638,
                    Publisher = "ＫＡＤＯＫＡＷＡ",
                },

                new Book
                {
                    Title = "覇剣の皇姫アルティーナ　小綺譚",
                    Price = 638,
                    Publisher = "ＫＡＤＯＫＡＷＡ",
                },

                new Book
                {
                    Title = "ラスト・フェニックス",
                    Price = 682,
                    Publisher = "ＫＡＤＯＫＡＷＡ",
                },

                new Book
                {
                    Title = "紅霞後宮物語",
                    Price = 638,
                    Publisher = "ＫＡＤＯＫＡＷＡ",
                },

                new Book
                {
                    Title = "１００万回死んでも少女は死体回収屋の苦労を知らない",
                    Price = 638,
                    Publisher = "ＫＡＤＯＫＡＷＡ",
                },

                new Book
                {
                    Title = "魔法使いは超能力者を殺せるか　サイ＆ソーサリィ",
                    Price = 704,
                    Publisher = "講談社",
                },

                new Book
                {
                    Title = "花×華",
                    Price = 649,
                    Publisher = "アスキー・メディアワークス",
                },

                new Book
                {
                    Title = "僕の妹は漢字が読める",
                    Price = 681,
                    Publisher = "ホビージャパン",
                },

                new Book
                {
                    Title = "オトコを見せてよ倉田くん！",
                    Price = 638,
                    Publisher = "メディアファクトリー",
                },

                new Book
                {
                    Title = "この中に１人、妹がいる！",
                    Price = 638,
                    Publisher = "メディアファクトリー",
                },

                new Book
                {
                    Title = "ジョシコーセーの成分。－ＳＣＨＯＯＬ　ＧＩＲＬ　ＯＶＥＲＦＬＯＷ－",
                    Price = 627,
                    Publisher = "アスキー・メディアワークス",
                },

                new Book
                {
                    Title = "おまえをオタクにしてやるから、俺をリア充にしてくれ！　小豆エンド",
                    Price = 660,
                    Publisher = "ＫＡＤＯＫＡＷＡ",
                },

                new Book
                {
                    Title = "天使の３Ｐ！",
                    Price = 561,
                    Publisher = "アスキー・メディアワークス",
                },

                new Book
                {
                    Title = "戦極ヤヲヨロズ",
                    Price = 638,
                    Publisher = "ＫＡＤＯＫＡＷＡ",
                },

                new Book
                {
                    Title = "伝説兄妹！",
                    Price = 503,
                    Publisher = "宝島社",
                },

                new Book
                {
                    Title = "いもうとがかり",
                    Price = 638,
                    Publisher = "メディアファクトリー",
                },

                new Book
                {
                    Title = "私とあなたの青春革命。",
                    Price = 671,
                    Publisher = "アスキー・メディアワークス",
                },

                new Book
                {
                    Title = "流星（ほし）生まれのスピカ",
                    Price = 671,
                    Publisher = "集英社",
                },

                new Book
                {
                    Title = "マーシアン・ウォースクール",
                    Price = 671,
                    Publisher = "ＫＡＤＯＫＡＷＡ",
                },

                new Book
                {
                    Title = "革命機ヴァルヴレイヴ",
                    Price = 671,
                    Publisher = "アスキー・メディアワークス",
                },

                new Book
                {
                    Title = "ワールドエンドライツ",
                    Price = 681,
                    Publisher = "ホビージャパン",
                },

                new Book
                {
                    Title = "シャーロック・ホームズ全集(1)－緋色の習作－",
                    Price = 715,
                    Publisher = "河出書房新社",
                },

                new Book
                {
                    Title = "オリエント急行の殺人－クリスティー文庫－　（ポアロシリーズ８）",
                    Price = 748,
                    Publisher = "早川書房",
                },

                new Book
                {
                    Title = "ＣＳＩ：科学捜査班－コールド・バーン－",
                    Price = 776,
                    Publisher = "角川書店",
                },

                new Book
                {
                    Title = "背信の海",
                    Price = 922,
                    Publisher = "集英社",
                },

                new Book
                {
                    Title = "人を動かす",
                    Price = 715,
                    Publisher = "創元社",
                },

                new Book
                {
                    Title = "ふむふむ",
                    Price = 649,
                    Publisher = "新潮社",
                },

                new Book
                {
                    Title = "娘の味",
                    Price = 506,
                    Publisher = "新潮社",
                },

                new Book
                {
                    Title = "ハーバード式脱暗記型思考術",
                    Price = 539,
                    Publisher = "新潮社",
                },

                new Book
                {
                    Title = "スタンフォードの自分を変える教室",
                    Price = 814,
                    Publisher = "大和書房",
                }
            );
            context.SaveChanges();
        }
    }
}