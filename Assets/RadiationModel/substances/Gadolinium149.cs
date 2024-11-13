
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gadolinium149 : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium149";
        public override double halfLife { get; } = 801792.0d;
        public override double atomicWeight { get; } = 148.91935d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Europium149() } },

            { 4.2999999999999995e-06d, new List<RadioactiveSubstance> { new AlphaParticle(), new Samarium145() } },

        };
    }
}
    
    