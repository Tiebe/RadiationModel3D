using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Arsenic68 : RadioactiveSubstance
    {
        public override string name { get; } = "Arsenic68";
        public override double halfLife { get; } = 151.6d;
        public override double atomicWeight { get; } = 67.93677d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gallium68() }, { 1.0d, new BetaParticle(1, 4095800.0) }, { 0.01161d, new GammaParticle(190300.0, 0.00652) }, { 0.00043344d, new GammaParticle(403800.0, 0.00307) }, { 0.00120744d, new GammaParticle(564000.0, 0.0022) }, { 0.09675d, new GammaParticle(612000.0, 0.00203) }, { 0.318888d, new GammaParticle(651200.0, 0.0019) }, { 0.006966d, new GammaParticle(702900.0, 0.00176) }, { 0.030186d, new GammaParticle(738400.0, 0.00168) }, { 0.33514200000000005d, new GammaParticle(761800.0, 0.00163) }, { 0.00053406d, new GammaParticle(871200.0, 0.00142) }, { 0.010062d, new GammaParticle(988300.0, 0.00125) }, { 0.774d, new GammaParticle(1016100.0, 0.00122) }, { 0.017802d, new GammaParticle(1052700.0, 0.00118) }, { 0.009288d, new GammaParticle(1169700.0, 0.00106) }, { 0.004644d, new GammaParticle(1245100.0, 0.001) }, { 0.044892d, new GammaParticle(1252400.0, 0.00099) }, { 0.051084d, new GammaParticle(1263400.0, 0.00098) }, { 0.005417999999999999d, new GammaParticle(1309600.0, 0.00095) }, { 0.01161d, new GammaParticle(1332800.0, 0.00093) }, { 0.151704d, new GammaParticle(1413300.0, 0.00088) }, { 0.0053406d, new GammaParticle(1441000.0, 0.00086) }, { 0.041796d, new GammaParticle(1622500.0, 0.00076) }, { 0.010062d, new GammaParticle(1633200.0, 0.00076) }, { 0.017028d, new GammaParticle(1639900.0, 0.00076) }, { 0.010062d, new GammaParticle(1645900.0, 0.00075) }, { 0.199692d, new GammaParticle(1778100.0, 0.0007) }, { 0.013932d, new GammaParticle(1814700.0, 0.00068) }, { 0.035604d, new GammaParticle(2007400.0, 0.00062) }, { 0.005417999999999999d, new GammaParticle(2025300.0, 0.00061) }, { 0.003096d, new GammaParticle(2071800.0, 0.0006) }, { 0.001548d, new GammaParticle(2229000.0, 0.00056) }, { 0.00774d, new GammaParticle(2271300.0, 0.00055) }, { 0.009288d, new GammaParticle(2384600.0, 0.00052) }, { 0.010062d, new GammaParticle(2457600.0, 0.0005) }, { 0.050309999999999994d, new GammaParticle(2458800.0, 0.0005) }, { 0.013932d, new GammaParticle(2506200.0, 0.00049) }, { 0.012384d, new GammaParticle(2793400.0, 0.00044) }, { 0.008514d, new GammaParticle(3058000.0, 0.00041) }, { 0.010062d, new GammaParticle(3088300.0, 0.0004) }, { 0.001548d, new GammaParticle(3222600.0, 0.00038) }, { 0.003096d, new GammaParticle(3288400.0, 0.00038) }, { 0.002322d, new GammaParticle(3401300.0, 0.00036) }, { 0.00387d, new GammaParticle(3551600.0, 0.00035) }, { 1.982d, new GammaParticle(511000.0, 0.00243) }, { 0.000225d, new GammaParticle(1221.0, 1.01543) }, { 0.00189d, new GammaParticle(9856.0, 0.1258) }, { 0.00367d, new GammaParticle(9887.0, 0.1254) }, { 0.00082d, new GammaParticle(11026.0, 0.11245) }, { 0.00084d, new GammaParticle(11038.0, 0.11232) }, { 1.8e-05d, new GammaParticle(11099.0, 0.11171) } } },

        };
    }
}
    