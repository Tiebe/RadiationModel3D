
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium155 : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium155";
        public override double halfLife { get; } = 1330.8d;
        public override double atomicWeight { get; } = 154.92465d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Europium155() } },

        };
    }
}
    
    