using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium121m : RadioactiveSubstance
    {
        public override string name { get; } = "Indium121m";
        public override double halfLife { get; } = 232.8d;
        public override double atomicWeight { get; } = 120.90819d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.988d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tin121() }, { 1.0d, new BetaParticle(-1, 1837800.0) }, { 0.21d, new GammaParticle(60100.0, 0.02063) }, { 0.0033d, new GammaParticle(908900.0, 0.00136) }, { 0.011000000000000001d, new GammaParticle(1041200.0, 0.00119) }, { 0.009000000000000001d, new GammaParticle(1102200.0, 0.00112) }, { 0.0051d, new GammaParticle(1120400.0, 0.00111) }, { 0.0005099999999999999d, new GammaParticle(1403000.0, 0.00088) }, { 0.0011d, new GammaParticle(2803800.0, 0.00044) }, { 0.001d, new GammaParticle(2864300.0, 0.00043) }, { 0.0009d, new GammaParticle(3059700.0, 0.00041) }, { 0.00015d, new GammaParticle(3228000.0, 0.00038) }, { 0.0345152724d, new GammaParticle(3753.0, 0.33036) }, { 0.10768756467236829d, new GammaParticle(25044.0, 0.04951) }, { 0.20154887642217534d, new GammaParticle(25271.0, 0.04906) }, { 0.056990441859194926d, new GammaParticle(28579.0, 0.04338) }, { 0.06821755890545633d, new GammaParticle(28810.0, 0.04304) }, { 0.011227117046261401d, new GammaParticle(29107.0, 0.0426) } } },
            { 0.012d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Indium121() }, { 0.0048d, new GammaParticle(313600.0, 0.00395) }, { 0.00044450325504d, new GammaParticle(3571.0, 0.3472) }, { 0.0013563119763945058d, new GammaParticle(24001.0, 0.05166) }, { 0.0025446753778508554d, new GammaParticle(24209.0, 0.05121) }, { 0.0007139790300459156d, new GammaParticle(27367.0, 0.0453) }, { 0.0008496350457546395d, new GammaParticle(27581.0, 0.04495) }, { 0.00013565601570872396d, new GammaParticle(27858.0, 0.04451) } } },

        };
    }
}
    