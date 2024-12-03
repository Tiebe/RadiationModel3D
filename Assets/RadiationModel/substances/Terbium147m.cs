using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Terbium147m : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium147m";
        public override double halfLife { get; } = 109.8d;
        public override double atomicWeight { get; } = 146.92411d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Europium147()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.0006d, new GammaParticle(442600.0, 0.0028)), new(0.0044d, new GammaParticle(704500.0, 0.00176)), new(0.0026d, new GammaParticle(927300.0, 0.00134)), new(0.0014000000000000002d, new GammaParticle(947100.0, 0.00131)), new(0.011000000000000001d, new GammaParticle(997200.0, 0.00124)), new(0.0024d, new GammaParticle(1027300.0, 0.00121)), new(0.0017000000000000001d, new GammaParticle(1116300.0, 0.00111)), new(0.0008d, new GammaParticle(1125700.0, 0.0011)), new(0.0031d, new GammaParticle(1260700.0, 0.00098)), new(0.0015d, new GammaParticle(1362500.0, 0.00091)), new(0.0016d, new GammaParticle(1388800.0, 0.00089)), new(0.79d, new GammaParticle(1397300.0, 0.00089)), new(0.0013d, new GammaParticle(1407500.0, 0.00088)), new(0.0032d, new GammaParticle(1574200.0, 0.00079)), new(0.009000000000000001d, new GammaParticle(1608700.0, 0.00077)), new(0.0005d, new GammaParticle(1628300.0, 0.00076)), new(0.0092d, new GammaParticle(1642700.0, 0.00075)), new(0.149d, new GammaParticle(1798200.0, 0.00069)), new(0.0024d, new GammaParticle(1807100.0, 0.00069)), new(0.0073d, new GammaParticle(1944100.0, 0.00064)), new(0.0062d, new GammaParticle(2078400.0, 0.0006)), new(0.0036d, new GammaParticle(2875200.0, 0.00043)), new(0.0058d, new GammaParticle(2971400.0, 0.00042)), new(0.006500000000000001d, new GammaParticle(3005400.0, 0.00041)), new(0.0067d, new GammaParticle(3204600.0, 0.00039)), new(0.0067d, new GammaParticle(3322200.0, 0.00037)), new(0.6221124d, new GammaParticle(511000.0, 0.00243)), new(0.102d, new GammaParticle(6858.0, 0.18079)), new(0.1537d, new GammaParticle(42308.0, 0.02931)), new(0.27649999999999997d, new GammaParticle(42996.0, 0.02884)), new(0.0874d, new GammaParticle(48802.0, 0.02541)), new(0.1104d, new GammaParticle(49326.0, 0.02514)), new(0.023d, new GammaParticle(49957.0, 0.02482)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    