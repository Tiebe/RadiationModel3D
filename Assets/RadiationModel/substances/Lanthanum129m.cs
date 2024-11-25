using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum129m : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum129m";
        public override double halfLife { get; } = 0.56d;
        public override double atomicWeight { get; } = 128.91288d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lanthanum129() }, { 0.23800000000000002d, new GammaParticle(68200.0, 0.01818) }, { 0.042839999999999996d, new GammaParticle(104000.0, 0.01192) }, { 0.1626168083904d, new GammaParticle(5185.0, 0.23912) }, { 0.22767666532160089d, new GammaParticle(33034.0, 0.03753) }, { 0.41821577024540946d, new GammaParticle(33442.0, 0.03707) }, { 0.12453919587628869d, new GammaParticle(37908.0, 0.03271) }, { 0.15604761243298973d, new GammaParticle(38273.0, 0.03239) }, { 0.03150841655670104d, new GammaParticle(38725.0, 0.03202) } } },

        };
    }
}
    