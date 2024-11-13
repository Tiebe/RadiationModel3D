
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium161 : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium161";
        public override double halfLife { get; } = 4.8d;
        public override double atomicWeight { get; } = 160.93916d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Europium161() } },

        };
    }
}
    
    