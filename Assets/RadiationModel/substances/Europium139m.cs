using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium139m : RadioactiveSubstance
    {
        public override string name { get; } = "Europium139m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 138.92995d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00838, 148000.0), new Europium139() } },

        };
    }
}
    
    