
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine134m : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine134m";
        public override double halfLife { get; } = 211.2d;
        public override double atomicWeight { get; } = 133.91012d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.977d, new List<RadioactiveSubstance> { new GammaParticle(), new Iodine134() } },

            { 0.023d, new List<RadioactiveSubstance> { new BetaParticle(), new Xenon134() } },

        };
    }
}
    
    