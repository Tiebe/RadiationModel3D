
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Helium5 : RadioactiveSubstance
    {
        public override string name { get; } = "Helium5";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 5.01206d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new NeutronParticle(), new Helium4() } },

        };
    }
}
    
    