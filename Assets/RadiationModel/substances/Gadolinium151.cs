
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gadolinium151 : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium151";
        public override double halfLife { get; } = 10704960.0d;
        public override double atomicWeight { get; } = 150.92035d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new Europium151() } },

            { 1.1000000000000001e-08d, new List<RadioactiveSubstance> { new AlphaParticle(), new Samarium147() } },

        };
    }
}
    
    