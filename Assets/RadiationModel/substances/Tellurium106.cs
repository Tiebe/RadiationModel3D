using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium106 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium106";
        public override double halfLife { get; } = 8e-05d;
        public override double atomicWeight { get; } = 105.9375d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(5305047.4), new Tin102() } },

        };
    }
}
    
    