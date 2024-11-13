
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium133 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium133";
        public override double halfLife { get; } = 750.0d;
        public override double atomicWeight { get; } = 132.91096d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Iodine133() } },

        };
    }
}
    
    