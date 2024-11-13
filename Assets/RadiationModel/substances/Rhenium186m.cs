
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium186m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium186m";
        public override double halfLife { get; } = 6311390400000.0d;
        public override double atomicWeight { get; } = 185.95515d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Rhenium186() } },

        };
    }
}
    
    