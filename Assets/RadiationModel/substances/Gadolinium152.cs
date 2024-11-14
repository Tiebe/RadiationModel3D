using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gadolinium152 : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium152";
        public override double halfLife { get; } = 3.408150816e+21d;
        public override double atomicWeight { get; } = 151.9198d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(3223847.4), new Samarium148() } },

        };
    }
}
    
    