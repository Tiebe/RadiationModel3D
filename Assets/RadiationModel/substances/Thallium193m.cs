
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium193m : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium193m";
        public override double halfLife { get; } = 126.6d;
        public override double atomicWeight { get; } = 192.9709d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.75d, new List<RadioactiveSubstance> { new GammaParticle(), new Thallium193() } },

            { 0.25d, new List<RadioactiveSubstance> { new BetaParticle(), new Mercury193() } },

        };
    }
}
    
    