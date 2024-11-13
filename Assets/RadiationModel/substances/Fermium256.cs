
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fermium256 : RadioactiveSubstance
    {
        public override string name { get; } = "Fermium256";
        public override double halfLife { get; } = 9426.0d;
        public override double atomicWeight { get; } = 256.09177d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.919d, new List<RadioactiveSubstance> {  } },

            { 0.081d, new List<RadioactiveSubstance> { new AlphaParticle(), new Californium252() } },

        };
    }
}
    
    