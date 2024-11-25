using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium93 : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium93";
        public override double halfLife { get; } = 9900.0d;
        public override double atomicWeight { get; } = 92.91025d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Niobium93() }, { 1.0d, new BetaParticle(1, 1803350.0) }, { 0.0007281999999999999d, new GammaParticle(114200.0, 0.01086) }, { 0.0013239999999999999d, new GammaParticle(171000.0, 0.00725) }, { 0.662d, new GammaParticle(1362940.0, 0.00091) }, { 0.005693200000000001d, new GammaParticle(1381640.0, 0.0009) }, { 0.0025818000000000004d, new GammaParticle(1424600.0, 0.00087) }, { 0.08672200000000001d, new GammaParticle(1477140.0, 0.00084) }, { 0.243616d, new GammaParticle(1520280.0, 0.00082) }, { 0.007613d, new GammaParticle(1538800.0, 0.00081) }, { 0.0031643599999999997d, new GammaParticle(2409050.0, 0.00051) }, { 0.00045016d, new GammaParticle(2479000.0, 0.0005) }, { 0.0035086d, new GammaParticle(2730800.0, 0.00045) }, { 0.00029790000000000003d, new GammaParticle(2821800.0, 0.00044) }, { 0.0008738400000000001d, new GammaParticle(2902000.0, 0.00043) }, { 0.00015888d, new GammaParticle(3025800.0, 0.00041) }, { 0.2186d, new GammaParticle(511000.0, 0.00243) }, { 0.034007490155738666d, new GammaParticle(2440.0, 0.50813) }, { 0.17075417862893105d, new GammaParticle(17374.0, 0.07136) }, { 0.32543201568311614d, new GammaParticle(17479.0, 0.07093) }, { 0.08539218214070415d, new GammaParticle(19681.0, 0.063) }, { 0.09854257819037258d, new GammaParticle(19794.0, 0.06264) }, { 0.013150396049668438d, new GammaParticle(19963.0, 0.06211) } } },

        };
    }
}
    