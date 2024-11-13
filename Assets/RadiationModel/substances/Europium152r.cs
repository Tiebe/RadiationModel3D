
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium152r : RadioactiveSubstance
    {
        public override string name { get; } = "Europium152r";
        public override double halfLife { get; } = 5748.0d;
        public override double atomicWeight { get; } = 151.92191d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Europium152() } },

        };
    }
}
    
    