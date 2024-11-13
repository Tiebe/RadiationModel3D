
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium184m : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium184m";
        public override double halfLife { get; } = 10.6d;
        public override double atomicWeight { get; } = 183.98182d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.9953d, new List<RadioactiveSubstance> { new BetaParticle(), new Mercury184() } },

            { 0.004699999999999999d, new List<RadioactiveSubstance> { new AlphaParticle(), new Gold180() } },

        };
    }
}
    
    