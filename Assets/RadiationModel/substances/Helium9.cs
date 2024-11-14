using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Helium9 : RadioactiveSubstance
    {
        public override string name { get; } = "Helium9";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 9.04395d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new NeutronParticle(), new Helium8() } },

        };
    }
}
    
    