using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Potassium49 : RadioactiveSubstance
    {
        public override string name { get; } = "Potassium49";
        public override double halfLife { get; } = 1.26d;
        public override double atomicWeight { get; } = 48.96821d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 11688500.0), new Calcium49() } },

        };
    }
}
    
    