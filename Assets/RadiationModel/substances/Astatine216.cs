using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine216 : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine216";
        public override double halfLife { get; } = 0.0003d;
        public override double atomicWeight { get; } = 216.00242d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bismuth212() }, { 1.0d, new AlphaParticle(8971902.09) }, { 3e-05d, new GammaParticle(37600.0, 0.03297) }, { 0.0002d, new GammaParticle(97900.0, 0.01266) }, { 0.00023d, new GammaParticle(103400.0, 0.01199) }, { 0.0027d, new GammaParticle(115200.0, 0.01076) }, { 0.0001d, new GammaParticle(204800.0, 0.00605) }, { 0.00025d, new GammaParticle(300000.0, 0.00413) }, { 0.00033d, new GammaParticle(379300.0, 0.00327) }, { 0.0013d, new GammaParticle(417900.0, 0.00297) }, { 0.0071763903445d, new GammaParticle(12904.0, 0.09608) }, { 0.004751757904624617d, new GammaParticle(74815.0, 0.01657) }, { 0.007950071782875384d, new GammaParticle(77108.0, 0.01608) }, { 0.0027232100401990813d, new GammaParticle(87388.0, 0.01419) }, { 0.0035565123125d, new GammaParticle(88458.0, 0.01402) }, { 0.0008333022723009189d, new GammaParticle(89784.0, 0.01381) } } },
            { 6e-05d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Radon216() }, { 1.0d, new BetaParticle(-1, 1002000.0) } } },
            { 3e-09d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Polonium216() } } },

        };
    }
}
    