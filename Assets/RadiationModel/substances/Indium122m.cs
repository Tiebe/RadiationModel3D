using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium122m : RadioactiveSubstance
    {
        public override string name { get; } = "Indium122m";
        public override double halfLife { get; } = 1.5d;
        public override double atomicWeight { get; } = 121.91033d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tin122() }, { 1.0d, new BetaParticle(-1, 3205000.0) }, { 0.00261d, new GammaParticle(400270.0, 0.0031) }, { 0.00493d, new GammaParticle(947720.0, 0.00131) }, { 0.026680000000000002d, new GammaParticle(1013120.0, 0.00122) }, { 0.29d, new GammaParticle(1140280.0, 0.00109) }, { 0.00261d, new GammaParticle(1274900.0, 0.00097) }, { 0.00435d, new GammaParticle(1352150.0, 0.00092) }, { 0.01798d, new GammaParticle(1389700.0, 0.00089) }, { 0.00522d, new GammaParticle(1634960.0, 0.00076) }, { 0.00203d, new GammaParticle(1830600.0, 0.00068) }, { 0.01972d, new GammaParticle(2065620.0, 0.0006) }, { 0.001015d, new GammaParticle(2153740.0, 0.00058) }, { 0.002465d, new GammaParticle(2165500.0, 0.00057) }, { 0.00435d, new GammaParticle(2408230.0, 0.00051) }, { 0.00551d, new GammaParticle(2415480.0, 0.00051) }, { 0.00261d, new GammaParticle(2734600.0, 0.00045) }, { 0.03074d, new GammaParticle(2759130.0, 0.00045) }, { 0.00232d, new GammaParticle(2775700.0, 0.00045) }, { 0.001305d, new GammaParticle(2966000.0, 0.00042) }, { 0.008409999999999999d, new GammaParticle(2975700.0, 0.00042) }, { 0.00116d, new GammaParticle(3039000.0, 0.00041) }, { 0.00116d, new GammaParticle(3582800.0, 0.00035) }, { 0.00261d, new GammaParticle(3819700.0, 0.00032) }, { 0.00116d, new GammaParticle(4004000.0, 0.00031) }, { 0.00145d, new GammaParticle(4106700.0, 0.0003) }, { 2.1950450859458e-05d, new GammaParticle(3753.0, 0.33036) }, { 6.895270477808238e-05d, new GammaParticle(25044.0, 0.04951) }, { 0.0001290524139586045d, new GammaParticle(25271.0, 0.04906) }, { 3.6491168916719405e-05d, new GammaParticle(28579.0, 0.04338) }, { 4.3679929193313126e-05d, new GammaParticle(28810.0, 0.04304) }, { 7.188760276593722e-06d, new GammaParticle(29107.0, 0.0426) } } },

        };
    }
}
    