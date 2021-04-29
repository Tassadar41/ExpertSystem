using System;
using System.Collections.Generic;
using chen0040.ExpertSystem;

namespace ExpertSystem
{
    class Program
    {
		public static RuleInferenceEngine getInferenceEngine()
		{
			RuleInferenceEngine rie = new RuleInferenceEngine();

			Rule rule = new Rule("Англиский бульдог");
			rule.AddAntecedent(new IsClause("Какая собака: длинношерстная или короткошерстная?", "короткошерстная"));
			rule.AddAntecedent(new IsClause("Каков рост собаки: менее 50 см или более?", "менее"));
			rule.AddAntecedent(new IsClause("У собаки короткий или длинный хвост?", "короткий"));
			rule.setConsequent(new IsClause("собака", "Англиский бульдог"));
			rie.AddRule(rule);

			rule = new Rule("Гончая");
			rule.AddAntecedent(new IsClause("Какая собака: длинношерстная или короткошерстная?", "короткошерстная"));
			rule.AddAntecedent(new IsClause("Каков рост собаки: менее 50 см или более?", "менее"));
			rule.AddAntecedent(new IsClause("У собаки короткий или длинный хвост?", "длинный"));
			rule.AddAntecedent(new IsClause("Длинные или короткие уши у собаки?", "длинные"));
			rule.setConsequent(new IsClause("собака", "Гончая"));
			rie.AddRule(rule);

			rule = new Rule("Мопс");
			rule.AddAntecedent(new IsClause("Какая собака: длинношерстная или короткошерстная?", "короткошерстная"));
			rule.AddAntecedent(new IsClause("Каков рост собаки: менее 50 см или более?", "менее"));
			rule.AddAntecedent(new IsClause("У собаки короткий или длинный хвост?", "длинный"));
			rule.AddAntecedent(new IsClause("Длинные или короткие уши у собаки?", "короткие"));
			rule.AddAntecedent(new IsClause("Тело длинное или короткое?", "короткое"));
			rule.setConsequent(new IsClause("собака", "Мопс"));
			rie.AddRule(rule);

			rule = new Rule("Чихуахуа");
			rule.AddAntecedent(new IsClause("Какая собака: длинношерстная или короткошерстная?", "короткошерстная"));
			rule.AddAntecedent(new IsClause("Каков рост собаки: менее 50 см или более?", "менее"));
			rule.AddAntecedent(new IsClause("У собаки короткий или длинный хвост?", "длинный"));
			rule.AddAntecedent(new IsClause("Длинные или короткие уши у собаки?", "короткие"));
			rule.AddAntecedent(new IsClause("Тело длинное или короткое?", "длинное"));
			rule.setConsequent(new IsClause("собака", "Чихуахуа"));
			rie.AddRule(rule);

			rule = new Rule("Датский дог");
			rule.AddAntecedent(new IsClause("Какая собака: длинношерстная или короткошерстная?", "короткошерстная"));
			rule.AddAntecedent(new IsClause("Каков рост собаки: менее 50 см или более?", "более"));
			rule.AddAntecedent(new IsClause("Собака весит более 50 кг или менее?", "более"));
			rule.setConsequent(new IsClause("собака", "Датский дог"));
			rie.AddRule(rule);

			rule = new Rule("Фоксхаунд");
			rule.AddAntecedent(new IsClause("Какая собака: длинношерстная или короткошерстная?", "короткошерстная"));
			rule.AddAntecedent(new IsClause("Каков рост собаки: менее 50 см или более?", "более"));
			rule.AddAntecedent(new IsClause("Собака весит более 50 кг или менее?", "менее"));
			rule.setConsequent(new IsClause("собака", "Фоксхаунд"));
			rie.AddRule(rule);

			rule = new Rule("Кокер спаниель");
			rule.AddAntecedent(new IsClause("Какая собака: длинношерстная или короткошерстная?", "длинношерстная"));
			rule.AddAntecedent(new IsClause("Каков рост собаки: менее 50 см или более?", "менее"));
			rule.AddAntecedent(new IsClause("У собаки доброжелательный характер", "да"));
			rule.setConsequent(new IsClause("собака", "Кокер спаниель"));
			rie.AddRule(rule);

			rule = new Rule("Ирландский сеттер");
			rule.AddAntecedent(new IsClause("Какая собака: длинношерстная или короткошерстная?", "длинношерстная"));
			rule.AddAntecedent(new IsClause("Каков рост собаки: менее 50 см или более?", "менее"));
			rule.AddAntecedent(new IsClause("У собаки доброжелательный характер", "нет"));
			rule.setConsequent(new IsClause("собака", "Ирландский сеттер"));
			rie.AddRule(rule);

			rule = new Rule("Большой вандейский грифон");
			rule.AddAntecedent(new IsClause("Какая собака: длинношерстная или короткошерстная?", "длинношерстная"));
			rule.AddAntecedent(new IsClause("Каков рост собаки: менее 50 см или более?", "более"));
			rule.AddAntecedent(new IsClause("У собаки рост менее 70 см или более?", "менее"));
			rule.AddAntecedent(new IsClause("Длинные или короткие уши у собаки?", "длинные"));
			rule.setConsequent(new IsClause("собака", "Большой вандейский грифон"));
			rie.AddRule(rule);

			rule = new Rule("Колли");
			rule.AddAntecedent(new IsClause("Какая собака: длинношерстная или короткошерстная?", "длинношерстная"));
			rule.AddAntecedent(new IsClause("Каков рост собаки: менее 50 см или более?", "более"));
			rule.AddAntecedent(new IsClause("У собаки рост менее 70 см или более?", "менее"));
			rule.AddAntecedent(new IsClause("Длинные или короткие уши у собаки?", "короткие"));
			rule.setConsequent(new IsClause("собака", "Колли"));
			rie.AddRule(rule);

			rule = new Rule("Сенбернар");
			rule.AddAntecedent(new IsClause("Какая собака: длинношерстная или короткошерстная?", "длинношерстная"));
			rule.AddAntecedent(new IsClause("Каков рост собаки: менее 50 см или более?", "более"));
			rule.AddAntecedent(new IsClause("У собаки рост менее 70 см или более?", "более"));
			rule.AddAntecedent(new IsClause("Окрас рыжий с белыми отметками?", "да"));
			rule.setConsequent(new IsClause("собака", "Сенбернар"));
			rie.AddRule(rule);

			rule = new Rule("Ирландский волкодав");
			rule.AddAntecedent(new IsClause("Какая собака: длинношерстная или короткошерстная?", "длинношерстная"));
			rule.AddAntecedent(new IsClause("Каков рост собаки: менее 50 см или более?", "более"));
			rule.AddAntecedent(new IsClause("У собаки рост менее 70 см или более?", "более"));
			rule.AddAntecedent(new IsClause("Окрас рыжий с белыми отметками?", "нет"));
			rule.AddAntecedent(new IsClause("Белоснежный окрас?", "да"));
			rule.setConsequent(new IsClause("собака", "Ирландский волкодав"));
			rie.AddRule(rule);

			rule = new Rule("Ньюфаундленд");
			rule.AddAntecedent(new IsClause("Какая собака: длинношерстная или короткошерстная?", "длинношерстная"));
			rule.AddAntecedent(new IsClause("Каков рост собаки: менее 50 см или более?", "более"));
			rule.AddAntecedent(new IsClause("У собаки рост менее 70 см или более?", "более"));
			rule.AddAntecedent(new IsClause("Окрас рыжий с белыми отметками?", "нет"));
			rule.AddAntecedent(new IsClause("Белоснежный окрас?", "нет"));
			rule.setConsequent(new IsClause("собака", "Ньюфаундленд"));
			rie.AddRule(rule);

			return rie;
		}

		static void Main(string[] args)
        {
			RuleInferenceEngine rie = getInferenceEngine();	
			
			rie.ClearFacts();

			List<Clause> unproved_conditions = new List<Clause>();

			Clause conclusion = null;
			while (conclusion == null)
			{
				conclusion = rie.Infer("собака", unproved_conditions);
				if (conclusion == null)
				{
					if (unproved_conditions.Count == 0)
					{
						break;
					}
					Clause c = unproved_conditions[0];
					unproved_conditions.Clear();
					Console.WriteLine("" + c.Variable);
					String value=null;
					value = Console.ReadLine();					
					rie.AddFact(new IsClause(c.Variable, value));
				}
			}

			Console.WriteLine("Результат: " + conclusion);
			Console.ReadLine();
		}
    }
}
