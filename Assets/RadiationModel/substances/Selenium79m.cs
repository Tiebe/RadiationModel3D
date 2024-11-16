using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Selenium79m : RadioactiveSubstance
    {
        public override string name { get; } = "Selenium79m";
        public override double halfLife { get; } = 234.0d;
        public override double atomicWeight { get; } = 78.9186d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((95770.0, 0.01295)), new Selenium79() } },
            { 0.0005600000000000001d, new List<RadioactiveSubstance> { new BetaParticle(-1, 246400.0), new Bromine79() } },

        };
    }
}
    
    