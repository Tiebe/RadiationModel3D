using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum176p : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum176p";
        public override double halfLife { get; } = 0.00097d;
        public override double atomicWeight { get; } = 175.94793d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00043, 2870000.0), new Tantalum176() } },

        };
    }
}
    
    