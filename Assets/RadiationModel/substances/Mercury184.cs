
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury184 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury184";
        public override double halfLife { get; } = 30.87d;
        public override double atomicWeight { get; } = 183.97172d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.9889d, new List<RadioactiveSubstance> { new BetaParticle(), new Gold184() } },

            { 0.0111d, new List<RadioactiveSubstance> { new AlphaParticle(), new Platinum180() } },

        };
    }
}
    
    