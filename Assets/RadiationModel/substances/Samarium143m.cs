using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium143m : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium143m";
        public override double halfLife { get; } = 66.0d;
        public override double atomicWeight { get; } = 142.91544d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9976d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Samarium143() }, { 0.9009999999999999d, new GammaParticle(754400.0, 0.00164) }, { 0.0128143411342d, new GammaParticle(6354.0, 0.19513) }, { 0.020303094377959737d, new GammaParticle(39522.0, 0.03137) }, { 0.03674768213205382d, new GammaParticle(40117.0, 0.03091) }, { 0.011487250945935163d, new GammaParticle(45523.0, 0.02724) }, { 0.014450961689986434d, new GammaParticle(45998.0, 0.02695) }, { 0.002963710744051272d, new GammaParticle(46575.0, 0.02662) } } },
            { 0.0024d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neodymium143() }, { 1.0d, new BetaParticle(1, 2619600.0) }, { 0.002d, new GammaParticle(689000.0, 0.0018) }, { 0.00037999999999999997d, new GammaParticle(963000.0, 0.00129) }, { 0.00192d, new GammaParticle(511000.0, 0.00243) }, { 0.00018735779282479998d, new GammaParticle(6109.0, 0.20295) }, { 0.00032999006630017857d, new GammaParticle(38171.0, 0.03248) }, { 0.0005991105052653932d, new GammaParticle(38724.0, 0.03202) }, { 0.0001857462001864982d, new GammaParticle(43934.0, 0.02822) }, { 0.00023348297363442818d, new GammaParticle(44387.0, 0.02793) }, { 4.7736773447930036e-05d, new GammaParticle(44938.0, 0.02759) } } },

        };
    }
}
    