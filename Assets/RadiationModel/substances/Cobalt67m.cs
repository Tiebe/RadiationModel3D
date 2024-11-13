
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt67m : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt67m";
        public override double halfLife { get; } = 0.496d;
        public override double atomicWeight { get; } = 66.94114d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.8d, new List<RadioactiveSubstance> { new GammaParticle(), new Cobalt67() } },

        };
    }
}
    
    