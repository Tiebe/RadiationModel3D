
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Oxygen26 : RadioactiveSubstance
    {
        public override string name { get; } = "Oxygen26";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 26.03721d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new NeutronParticle(), new Oxygen24() } },

        };
    }
}
    
    