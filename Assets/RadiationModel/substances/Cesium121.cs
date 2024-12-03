using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Cesium121 : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium121";
        public override double halfLife { get; } = 155.0d;
        public override double atomicWeight { get; } = 120.91723d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Iodine121()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.00132d, new GammaParticle(59300.0, 0.02091)), new(0.02046d, new GammaParticle(85900.0, 0.01443)), new(0.0066d, new GammaParticle(108000.0, 0.01148)), new(0.15015d, new GammaParticle(153900.0, 0.00806)), new(0.0165d, new GammaParticle(159700.0, 0.00776)), new(0.02673d, new GammaParticle(179400.0, 0.00691)), new(0.02442d, new GammaParticle(196000.0, 0.00633)), new(0.00726d, new GammaParticle(210100.0, 0.0059)), new(0.07656d, new GammaParticle(239600.0, 0.00517)), new(0.0165d, new GammaParticle(270200.0, 0.00459)), new(0.00165d, new GammaParticle(273200.0, 0.00454)), new(0.014190000000000001d, new GammaParticle(295800.0, 0.00419)), new(0.00363d, new GammaParticle(326800.0, 0.00379)), new(0.00231d, new GammaParticle(337200.0, 0.00368)), new(0.00297d, new GammaParticle(343200.0, 0.00361)), new(0.0231d, new GammaParticle(355900.0, 0.00348)), new(0.00198d, new GammaParticle(361700.0, 0.00343)), new(0.00363d, new GammaParticle(373800.0, 0.00332)), new(0.00264d, new GammaParticle(380100.0, 0.00326)), new(0.00231d, new GammaParticle(393200.0, 0.00315)), new(0.00462d, new GammaParticle(398800.0, 0.00311)), new(0.03597d, new GammaParticle(427100.0, 0.0029)), new(0.00132d, new GammaParticle(445400.0, 0.00278)), new(0.0033d, new GammaParticle(450100.0, 0.00275)), new(0.0033d, new GammaParticle(456600.0, 0.00272)), new(0.0069299999999999995d, new GammaParticle(456600.0, 0.00272)), new(0.00396d, new GammaParticle(466000.0, 0.00266)), new(0.0066d, new GammaParticle(481600.0, 0.00257)), new(0.0049499999999999995d, new GammaParticle(486100.0, 0.00255)), new(0.00957d, new GammaParticle(497600.0, 0.00249)), new(0.00594d, new GammaParticle(542600.0, 0.00229)), new(0.01188d, new GammaParticle(553000.0, 0.00224)), new(0.0033d, new GammaParticle(558300.0, 0.00222)), new(0.00264d, new GammaParticle(564500.0, 0.0022)), new(0.01122d, new GammaParticle(619900.0, 0.002)), new(0.00396d, new GammaParticle(646800.0, 0.00192)), new(0.01155d, new GammaParticle(661100.0, 0.00188)), new(0.00231d, new GammaParticle(674800.0, 0.00184)), new(0.00231d, new GammaParticle(682300.0, 0.00182)), new(0.00264d, new GammaParticle(690500.0, 0.0018)), new(0.00594d, new GammaParticle(696500.0, 0.00178)), new(0.00264d, new GammaParticle(797900.0, 0.00155)), new(0.00231d, new GammaParticle(841900.0, 0.00147)), new(0.0033d, new GammaParticle(850500.0, 0.00146)), new(0.00198d, new GammaParticle(867200.0, 0.00143)), new(0.00165d, new GammaParticle(881200.0, 0.00141)), new(0.00231d, new GammaParticle(891600.0, 0.00139)), new(0.00264d, new GammaParticle(900200.0, 0.00138)), new(0.00132d, new GammaParticle(905400.0, 0.00137)), new(0.0033d, new GammaParticle(914300.0, 0.00136)), new(0.00231d, new GammaParticle(922600.0, 0.00134)), new(0.00396d, new GammaParticle(936600.0, 0.00132)), new(0.00264d, new GammaParticle(949200.0, 0.00131)), new(0.00198d, new GammaParticle(986300.0, 0.00126)), new(0.00264d, new GammaParticle(1060300.0, 0.00117)), new(0.00264d, new GammaParticle(1076700.0, 0.00115)), new(0.00231d, new GammaParticle(1115000.0, 0.00111)), new(0.009899999999999999d, new GammaParticle(1140300.0, 0.00109)), new(0.00165d, new GammaParticle(1179800.0, 0.00105)), new(0.00198d, new GammaParticle(1255200.0, 0.00099)), new(0.0033d, new GammaParticle(1276400.0, 0.00097)), new(0.00231d, new GammaParticle(1396200.0, 0.00089)), new(0.0033d, new GammaParticle(1416500.0, 0.00088)), new(0.0132d, new GammaParticle(1432700.0, 0.00087)), new(0.00264d, new GammaParticle(1458000.0, 0.00085)), new(0.00264d, new GammaParticle(1497700.0, 0.00083)), new(0.00264d, new GammaParticle(1511100.0, 0.00082)), new(1.7830000000000001d, new GammaParticle(511000.0, 0.00243)), new(0.018487867971328d, new GammaParticle(4540.0, 0.27309)), new(0.0451716969022403d, new GammaParticle(29458.0, 0.04209)), new(0.08368228399822211d, new GammaParticle(29778.0, 0.04164)), new(0.024259159672765054d, new GammaParticle(33726.0, 0.03676)), new(0.029984321355537604d, new GammaParticle(34030.0, 0.03643)), new(0.005725161682772552d, new GammaParticle(34414.0, 0.03603)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    