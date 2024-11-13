
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium141 : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium141";
        public override double halfLife { get; } = 0.0041d;
        public override double atomicWeight { get; } = 140.96311d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new ProtonParticle(), new Dysprosium140() } },

        };
    }
}
    
    