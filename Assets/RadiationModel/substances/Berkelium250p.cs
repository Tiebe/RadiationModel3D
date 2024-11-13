
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Berkelium250p : RadioactiveSubstance
    {
        public override string name { get; } = "Berkelium250p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 250.07854d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Berkelium250() } },

        };
    }
}
    
    