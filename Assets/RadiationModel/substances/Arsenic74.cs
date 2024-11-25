using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Arsenic74 : RadioactiveSubstance
    {
        public override string name { get; } = "Arsenic74";
        public override double halfLife { get; } = 1535328.0d;
        public override double atomicWeight { get; } = 73.92393d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.66d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gallium74() }, { 1.0d, new BetaParticle(1, -1405250.0) }, { 0.59d, new GammaParticle(595830.0, 0.00208) }, { 0.005520000000000001d, new GammaParticle(608430.0, 0.00204) }, { 7.1e-05d, new GammaParticle(715300.0, 0.00173) }, { 3.6e-05d, new GammaParticle(734200.0, 0.00169) }, { 4.57e-05d, new GammaParticle(867200.0, 0.00143) }, { 0.00025499999999999996d, new GammaParticle(887000.0, 0.0014) }, { 0.000184d, new GammaParticle(993460.0, 0.00125) }, { 7.1e-05d, new GammaParticle(1101100.0, 0.00113) }, { 0.0028499999999999997d, new GammaParticle(1204350.0, 0.00103) }, { 7.1e-05d, new GammaParticle(1602500.0, 0.00077) }, { 0.000149d, new GammaParticle(2198200.0, 0.00056) }, { 0.582322d, new GammaParticle(511000.0, 0.00243) }, { 0.006140546021337337d, new GammaParticle(1221.0, 1.01543) }, { 0.051412228224251406d, new GammaParticle(9856.0, 0.1258) }, { 0.09984895751456867d, new GammaParticle(9887.0, 0.1254) }, { 0.022333965682962767d, new GammaParticle(11026.0, 0.11245) }, { 0.022825312927987947d, new GammaParticle(11038.0, 0.11232) }, { 0.0004913472450251809d, new GammaParticle(11099.0, 0.11171) } } },
            { 0.34d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Selenium74() }, { 1.0d, new BetaParticle(-1, 676555.0) }, { 0.154d, new GammaParticle(634780.0, 0.00195) }, { 0.000357d, new GammaParticle(635000.0, 0.00195) }, { 1.8e-05d, new GammaParticle(1269600.0, 0.00098) }, { 9.53580915e-09d, new GammaParticle(1426.0, 0.86945) }, { 7.359692777677288e-08d, new GammaParticle(11183.0, 0.11087) }, { 1.4268500926090128e-07d, new GammaParticle(11223.0, 0.11047) }, { 3.329619670737154e-08d, new GammaParticle(12546.0, 0.09882) }, { 3.516744296232582e-08d, new GammaParticle(12571.0, 0.09863) }, { 1.8712462549542806e-09d, new GammaParticle(12652.0, 0.098) } } },

        };
    }
}
    